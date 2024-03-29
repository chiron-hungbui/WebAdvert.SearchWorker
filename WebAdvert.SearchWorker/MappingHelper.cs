﻿
using AdvertAPI.Models.Messages;
using System;
using WebAdvert.SearchWorker.Models;

namespace WebAdvert.SearchWorker
{
    public class MappingHelper
    {
        public static AdvertType Map(AdvertConfirmedMessage message)
        {
            var doc = new AdvertType
            {
                Id = message.Id,
                Title = message.Title,
                CreationDateTime = DateTime.UtcNow
            };

            return doc;
        }
    }
}
