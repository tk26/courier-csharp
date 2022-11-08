using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Com.Courier.Model
{
    [DataContract(Name = "SendV2")]
    public partial class SendV2 : IEquatable<SendV2>, IValidatableObject
    {
        [JsonConstructor]
        protected SendV2() { }

        public SendV2(MessageV2 message)
        {
            this.Message = message ?? throw new ArgumentNullException("message is a required property for Send and cannot be null");
        }

        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = false)]
        public MessageV2 Message { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendV2 {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public override bool Equals(object input)
        {
            return this.Equals(input as SendV2);
        }

        public bool Equals(SendV2 input)
        {
            if (input == null)
                return false;

            return (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                );
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
