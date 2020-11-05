using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiSeit.Business.Channels
{
    public class TeaserChannel : DisplayChannel
    {
        public override string ChannelName
        {
            get
            {
                return "teaser";
            }
        }

        public override bool IsActive(HttpContextBase context)
        {
            return !context.Request.Browser.IsMobileDevice;
        }
    }
}