using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Com.Courier.Model
{
    [DataContract(Name = "MessageV2")]
    public partial class MessageV2 : IEquatable<MessageV2>, IValidatableObject
    {
        [JsonConstructor]
        protected MessageV2() { }

        public MessageV2(object to)
        {
            this.To = to ?? throw new ArgumentNullException("to is a required property for Message and cannot be null");
        }

        [DataMember(Name = "brand_id", EmitDefaultValue = false)]
        public string BrandId { get; set; }

        [DataMember(Name = "channels", EmitDefaultValue = false)]
        public object Channels { get; set; }

        [DataMember(Name = "content", EmitDefaultValue = false)]
        public object Content { get; set; }

        [DataMember(Name = "data", EmitDefaultValue = false)]
        public object Data { get; set; }

        [DataMember(Name = "delay", EmitDefaultValue = false)]
        public object Delay { get; set; }

        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public object Metadata { get; set; }

        [DataMember(Name = "providers", EmitDefaultValue = false)]
        public object Providers { get; set; }

        [DataMember(Name = "routing", EmitDefaultValue = false)]
        public object Routing { get; set; }

        [DataMember(Name = "template", EmitDefaultValue = false)]
        public string Template { get; set; }

        [DataMember(Name = "timeout", EmitDefaultValue = false)]
        public object Timeout { get; set; }


        [DataMember(Name = "to", EmitDefaultValue = false)]
        public object To { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageV2 {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            // can add more stuff later
            sb.Append("}\n");
            return sb.ToString();
        }

        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public override bool Equals(object input)
        {
            return this.Equals(input as MessageV2);
        }

        public bool Equals(MessageV2 input)
        {
            if (input == null)
                return false;

            return (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                );
            // can add more stuff later
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                // can add more stuff later
                return hashCode;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
