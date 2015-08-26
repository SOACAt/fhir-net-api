﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated on Wed, Aug 26, 2015 16:54+0200 for FHIR v0.5.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Request for a medication, substance or device
    /// </summary>
    [FhirType("SupplyRequest", IsResource=true)]
    [DataContract]
    public partial class SupplyRequest : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.SupplyRequest; } }
        [NotMapped]
        public override string TypeName { get { return "SupplyRequest"; } }
        
        /// <summary>
        /// Status of the supply request
        /// </summary>
        [FhirEnumeration("SupplyRequestStatus")]
        public enum SupplyRequestStatus
        {
            /// <summary>
            /// Supply has been requested, but not dispensed
            /// </summary>
            [EnumLiteral("requested")]
            Requested,
            /// <summary>
            /// Supply has been received by the requestor
            /// </summary>
            [EnumLiteral("completed")]
            Completed,
            /// <summary>
            /// The supply will not be completed because the supplier was unable or unwilling to supply the item
            /// </summary>
            [EnumLiteral("failed")]
            Failed,
            /// <summary>
            /// The orderer of the supply cancelled the request
            /// </summary>
            [EnumLiteral("cancelled")]
            Cancelled,
        }
        
        [FhirType("SupplyRequestWhenComponent")]
        [DataContract]
        public partial class SupplyRequestWhenComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SupplyRequestWhenComponent"; } }
            
            /// <summary>
            /// Fulfilment code
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Code;
            
            /// <summary>
            /// Formal fulfillment schedule
            /// </summary>
            [FhirElement("schedule", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Timing Schedule
            {
                get { return _Schedule; }
                set { _Schedule = value; OnPropertyChanged("Schedule"); }
            }
            
            private Hl7.Fhir.Model.Timing _Schedule;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SupplyRequestWhenComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
                    if(Schedule != null) dest.Schedule = (Hl7.Fhir.Model.Timing)Schedule.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new SupplyRequestWhenComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SupplyRequestWhenComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(Schedule, otherT.Schedule)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SupplyRequestWhenComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(Schedule, otherT.Schedule)) return false;
                
                return true;
            }
            
        }
        
        
        /// <summary>
        /// Patient for whom the item is supplied
        /// </summary>
        [FhirElement("patient", Order=90)]
        [References("Patient")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Patient
        {
            get { return _Patient; }
            set { _Patient = value; OnPropertyChanged("Patient"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Patient;
        
        /// <summary>
        /// Who initiated this order
        /// </summary>
        [FhirElement("source", Order=100)]
        [References("Practitioner","Organization","Patient")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Source
        {
            get { return _Source; }
            set { _Source = value; OnPropertyChanged("Source"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Source;
        
        /// <summary>
        /// When the request was made
        /// </summary>
        [FhirElement("date", Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// When the request was made
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if(value == null)
                  DateElement = null; 
                else
                  DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Unique identifier
        /// </summary>
        [FhirElement("identifier", Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private Hl7.Fhir.Model.Identifier _Identifier;
        
        /// <summary>
        /// requested | completed | failed | cancelled
        /// </summary>
        [FhirElement("status", Order=130)]
        [DataMember]
        public Code<Hl7.Fhir.Model.SupplyRequest.SupplyRequestStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.SupplyRequest.SupplyRequestStatus> _StatusElement;
        
        /// <summary>
        /// requested | completed | failed | cancelled
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.SupplyRequest.SupplyRequestStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.SupplyRequest.SupplyRequestStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// The kind of supply (central, non-stock, etc)
        /// </summary>
        [FhirElement("kind", Order=140)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Kind
        {
            get { return _Kind; }
            set { _Kind = value; OnPropertyChanged("Kind"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Kind;
        
        /// <summary>
        /// Medication, Substance, or Device requested to be supplied
        /// </summary>
        [FhirElement("orderedItem", Order=150)]
        [References("Medication","Substance","Device")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference OrderedItem
        {
            get { return _OrderedItem; }
            set { _OrderedItem = value; OnPropertyChanged("OrderedItem"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _OrderedItem;
        
        /// <summary>
        /// Who is intended to fulfill the request
        /// </summary>
        [FhirElement("supplier", Order=160)]
        [References("Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Supplier
        {
            get { if(_Supplier==null) _Supplier = new List<Hl7.Fhir.Model.ResourceReference>(); return _Supplier; }
            set { _Supplier = value; OnPropertyChanged("Supplier"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Supplier;
        
        /// <summary>
        /// Why the supply item was requested
        /// </summary>
        [FhirElement("reason", Order=170, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
        [DataMember]
        public Hl7.Fhir.Model.Element Reason
        {
            get { return _Reason; }
            set { _Reason = value; OnPropertyChanged("Reason"); }
        }
        
        private Hl7.Fhir.Model.Element _Reason;
        
        /// <summary>
        /// When the request should be fulfilled
        /// </summary>
        [FhirElement("when", Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.SupplyRequest.SupplyRequestWhenComponent When
        {
            get { return _When; }
            set { _When = value; OnPropertyChanged("When"); }
        }
        
        private Hl7.Fhir.Model.SupplyRequest.SupplyRequestWhenComponent _When;
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SupplyRequest;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Patient != null) dest.Patient = (Hl7.Fhir.Model.ResourceReference)Patient.DeepCopy();
                if(Source != null) dest.Source = (Hl7.Fhir.Model.ResourceReference)Source.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.Identifier)Identifier.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.SupplyRequest.SupplyRequestStatus>)StatusElement.DeepCopy();
                if(Kind != null) dest.Kind = (Hl7.Fhir.Model.CodeableConcept)Kind.DeepCopy();
                if(OrderedItem != null) dest.OrderedItem = (Hl7.Fhir.Model.ResourceReference)OrderedItem.DeepCopy();
                if(Supplier != null) dest.Supplier = new List<Hl7.Fhir.Model.ResourceReference>(Supplier.DeepCopy());
                if(Reason != null) dest.Reason = (Hl7.Fhir.Model.Element)Reason.DeepCopy();
                if(When != null) dest.When = (Hl7.Fhir.Model.SupplyRequest.SupplyRequestWhenComponent)When.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new SupplyRequest());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as SupplyRequest;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if( !DeepComparable.Matches(Source, otherT.Source)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(Kind, otherT.Kind)) return false;
            if( !DeepComparable.Matches(OrderedItem, otherT.OrderedItem)) return false;
            if( !DeepComparable.Matches(Supplier, otherT.Supplier)) return false;
            if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if( !DeepComparable.Matches(When, otherT.When)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SupplyRequest;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(Kind, otherT.Kind)) return false;
            if( !DeepComparable.IsExactly(OrderedItem, otherT.OrderedItem)) return false;
            if( !DeepComparable.IsExactly(Supplier, otherT.Supplier)) return false;
            if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if( !DeepComparable.IsExactly(When, otherT.When)) return false;
            
            return true;
        }
        
    }
    
}
