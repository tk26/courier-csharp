using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Com.Courier.Model
{
    [DataContract(Name = "MessageProviderConfig")]
    public partial class MessageProviderConfig : IEquatable<MessageProviderConfig>, IValidatableObject
    {
        public MessageProviderConfig()
        {
        }

        [DataMember(Name = "if", EmitDefaultValue = false)]
        public string If { get; set; }

        [DataMember(Name = "timeout", EmitDefaultValue = false)]
        public object Timeout { get; set; }

        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public object Metadata { get; set; }

        [DataMember(Name = "override", EmitDefaultValue = false)]
        public object Override { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageProviderConfig {\n");
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
            return this.Equals(input as MessageProviderConfig);
        }

        public bool Equals(MessageProviderConfig input)
        {
            if (input == null)
                return false;

            return true;
            // can add more stuff later
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
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
