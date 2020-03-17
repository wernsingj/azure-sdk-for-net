﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Avro.File;
using Avro.Generic;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.ChangeFeed.Models;

namespace Azure.Storage.ChangeFeed
{
    /// <summary>
    /// BlobChangeFeedPagableAsync.
    /// </summary>
    public class BlobChangeFeedAsyncPagable : AsyncPageable<BlobChangeFeedEvent>
    {
        private ChangeFeed _changeFeed;

        /// <summary>
        /// Internal constructor.
        /// </summary>
        internal BlobChangeFeedAsyncPagable(
            BlobServiceClient blobBerviceClient,
            DateTimeOffset? startTime = default,
            DateTimeOffset? endTime = default)
        {
            _changeFeed = new ChangeFeed(
                blobBerviceClient,
                startTime,
                endTime);
        }

        internal BlobChangeFeedAsyncPagable(
            BlobServiceClient blobServiceClient,
            BlobChangeFeedCursor cursor)
        {
            _changeFeed = new ChangeFeed(
                blobServiceClient,
                cursor);
        }

        /// <summary>
        /// AsPages.
        /// </summary>
        /// <param name="continuationToken"></param>
        /// <param name="pageSizeHint"></param>
        /// <returns></returns>
        public override async IAsyncEnumerable<Page<BlobChangeFeedEvent>> AsPages(
            string continuationToken = null,
            int? pageSizeHint = null)
        {
            while (_changeFeed.HasNext())
            {
                yield return await _changeFeed.GetPage(
                    async: true,
                    pageSize: pageSizeHint ?? 512).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Gets the Cursor to resume from the current position.
        /// </summary>
        /// <returns></returns>
        public BlobChangeFeedCursor GetCursor()
            => _changeFeed.GetCursor();
    }
}
