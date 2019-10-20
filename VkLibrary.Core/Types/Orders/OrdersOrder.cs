using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class OrdersOrder
    {
        ///<summary>
        /// Amount
        ///</summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        ///<summary>
        /// App order ID
        ///</summary>
        [JsonProperty("app_order_id")]
        public int AppOrderId { get; set; }

        ///<summary>
        /// Cancel transaction ID
        ///</summary>
        [JsonProperty("cancel_transaction_id")]
        public int CancelTransactionId { get; set; }

        ///<summary>
        /// Date of creation in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Order ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Order item
        ///</summary>
        [JsonProperty("item")]
        public String Item { get; set; }

        ///<summary>
        /// Receiver ID
        ///</summary>
        [JsonProperty("receiver_id")]
        public int ReceiverId { get; set; }

        ///<summary>
        /// Order status
        ///</summary>
        [JsonProperty("status")]
        public String Status { get; set; }

        ///<summary>
        /// Transaction ID
        ///</summary>
        [JsonProperty("transaction_id")]
        public int TransactionId { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}