using System.Collections.Generic;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for the a chat message list
    /// </summary>
    public class ChatMessageListViewModel : BaseViewModel
    {
        /// <summary>
        /// The chat thread items for the list
        /// </summary>
        public List<ChatMessageListItemViewModel> Items { get; set; }
    }
}
