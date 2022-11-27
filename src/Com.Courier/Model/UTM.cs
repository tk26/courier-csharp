using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Com.Courier.Model
{
    [DataContract(Name = "UTM")]
    public partial class UTM : IEquatable<UTM>, IValidatableObject
    {
        public UTM()
        {
        }

        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        [DataMember(Name = "medium", EmitDefaultValue = false)]
        public string Medium { get; set; }

        [DataMember(Name = "campaign", EmitDefaultValue = false)]
        public string Campaign { get; set; }

        [DataMember(Name = "term", EmitDefaultValue = false)]
        public string Term { get; set; }

        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UTM {\n");
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
            return this.Equals(input as UTM);
        }

        public bool Equals(UTM input)
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
