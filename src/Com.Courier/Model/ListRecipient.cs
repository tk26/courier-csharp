using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Com.Courier.Model
{
    [DataContract(Name = "ListRecipient")]
    public partial class ListRecipient : IEquatable<ListRecipient>, IValidatableObject
    {
        public ListRecipient()
        {
        }

        [DataMember(Name = "list_id", EmitDefaultValue = false)]
        public string ListId { get; set; }

        [DataMember(Name = "data", EmitDefaultValue = false)]
        public object Data { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRecipient {\n");
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
            return this.Equals(input as ListRecipient);
        }

        public bool Equals(ListRecipient input)
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
