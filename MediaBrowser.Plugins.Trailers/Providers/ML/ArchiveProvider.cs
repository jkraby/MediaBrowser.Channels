﻿using MediaBrowser.Controller.Channels;
using MediaBrowser.Model.Channels;
using MediaBrowser.Model.Entities;
using MediaBrowser.Model.Logging;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediaBrowser.Plugins.Trailers.Providers.ML
{
    public class ArchiveProvider : BaseProvider, IExtraProvider
    {
        public ArchiveProvider(ILogger logger)
            : base(logger)
        {
        }

        public ChannelMediaContentType ContentType
        {
            get { return ChannelMediaContentType.MovieExtra; }
        }

        public ExtraType ExtraType
        {
            get { return ExtraType.Trailer; }
        }

        public override TrailerType TrailerType
        {
            get { return TrailerType.Archive; }
        }

        public Task<IEnumerable<ChannelItemInfo>> GetChannelItems(CancellationToken cancellationToken)
        {
            return GetChannelItems(BaseUrl + "archive.php", cancellationToken);
        }
    }
}
