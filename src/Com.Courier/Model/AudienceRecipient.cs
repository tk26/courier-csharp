using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Com.Courier.Model
{
    [DataContract(Name = "AudienceRecipient")]
    public partial class AudienceRecipient : IEquatable<AudienceRecipient>, IValidatableObject
    {

        [JsonConstructor]
        protected AudienceRecipient() { }

        public AudienceRecipient(string audienceId)
        {
            this.AudienceId = audienceId ?? throw new ArgumentNullException("audienceId is a required property for AudienceRecipient and cannot be null");
        }

        [DataMember(Name = "audience_id", EmitDefaultValue = false)]
        public string AudienceId { get; set; }

        [DataMember(Name = "data", EmitDefaultValue = false)]
        public object Data { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudienceRecipient {\n");
            sb.Append("  AudienceId: ").Append(AudienceId).Append("\n");
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
            return this.Equals(input as AudienceRecipient);
        }

        public bool Equals(AudienceRecipient input)
        {
            if (input == null)
                return false;

            return (
                    this.AudienceId == input.AudienceId ||
                    (this.AudienceId != null &&
                    this.AudienceId.Equals(input.AudienceId))
                );
            // can add more stuff later
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AudienceId != null)
                    hashCode = hashCode * 59 + this.AudienceId.GetHashCode();
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
