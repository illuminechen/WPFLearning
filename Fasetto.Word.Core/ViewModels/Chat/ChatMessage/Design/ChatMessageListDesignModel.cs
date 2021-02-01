﻿using System;
using System.Collections.Generic;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The design-time data for a <see cref="ChatMessageListItemViewModel"/>
    /// </summary>
    public class ChatMessageListDesignModel : ChatMessageListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatMessageListDesignModel Instance => new ChatMessageListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatMessageListDesignModel()
        {
            Items = new List<ChatMessageListItemViewModel>
            {
                new ChatMessageListItemViewModel()
                {
                    SenderName="Parnell",
                    Initials="PL",
                    Message="I'm about to wipe the old server. We need to update the old server to Windows 2016",
                    ProfilePictureRGB="3099c5",
                    SentByMe=false,
                    MessageSentTime=DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.3)),
                    MessageReadTime=DateTimeOffset.UtcNow,
                },
                new ChatMessageListItemViewModel()
                {
                    SenderName="Luke",
                    Initials="LM",
                    Message="Let me know when you manage to spin up the new 2016 server",
                    ProfilePictureRGB="3099c5",
                    SentByMe=true,
                    MessageSentTime=DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.3)),
                    MessageReadTime=DateTimeOffset.UtcNow,
                },
                new ChatMessageListItemViewModel()
                {
                    SenderName="Parnell",
                    Initials="PL",
                    Message="The new server is up. Go to 192.168.1.1.\r\n Username is admin, password is P8ssw0rd!",
                    ProfilePictureRGB="3099c5",
                    SentByMe=false,
                    MessageSentTime=DateTimeOffset.UtcNow,
                },
            };
        }


        #endregion
    }
}
