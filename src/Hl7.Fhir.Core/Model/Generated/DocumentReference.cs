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
    /// A reference to a document
    /// </summary>
    [FhirType("DocumentReference", IsResource=true)]
    [DataContract]
    public partial class DocumentReference : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.DocumentReference; } }
        [NotMapped]
        public override string TypeName { get { return "DocumentReference"; } }
        
        /// <summary>
        /// The type of relationship between documents
        /// </summary>
        [FhirEnumeration("DocumentRelationshipType")]
        public enum DocumentRelationshipType
        {
            /// <summary>
            /// This document logically replaces or supersedes the target document
            /// </summary>
            [EnumLiteral("replaces")]
            Replaces,
            /// <summary>
            /// This document was generated by transforming the target document (e.g. format or language conversion)
            /// </summary>
            [EnumLiteral("transforms")]
            Transforms,
            /// <summary>
            /// This document is a signature of the target document
            /// </summary>
            [EnumLiteral("signs")]
            Signs,
            /// <summary>
            /// This document adds additional information to the target document
            /// </summary>
            [EnumLiteral("appends")]
            Appends,
        }
        
        [FhirType("DocumentReferenceContextComponent")]
        [DataContract]
        public partial class DocumentReferenceContextComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DocumentReferenceContextComponent"; } }
            
            /// <summary>
            /// Context of the document  content
            /// </summary>
            [FhirElement("encounter", InSummary=true, Order=40)]
            [References("Encounter")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Encounter
            {
                get { return _Encounter; }
                set { _Encounter = value; OnPropertyChanged("Encounter"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Encounter;
            
            /// <summary>
            /// Main Clinical Acts Documented
            /// </summary>
            [FhirElement("event", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Event
            {
                get { if(_Event==null) _Event = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Event; }
                set { _Event = value; OnPropertyChanged("Event"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Event;
            
            /// <summary>
            /// Time of service that is being documented
            /// </summary>
            [FhirElement("period", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.Period Period
            {
                get { return _Period; }
                set { _Period = value; OnPropertyChanged("Period"); }
            }
            
            private Hl7.Fhir.Model.Period _Period;
            
            /// <summary>
            /// Kind of facility where patient was seen
            /// </summary>
            [FhirElement("facilityType", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept FacilityType
            {
                get { return _FacilityType; }
                set { _FacilityType = value; OnPropertyChanged("FacilityType"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _FacilityType;
            
            /// <summary>
            /// Additional details about where the content was created (e.g. clinical specialty)
            /// </summary>
            [FhirElement("practiceSetting", InSummary=true, Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept PracticeSetting
            {
                get { return _PracticeSetting; }
                set { _PracticeSetting = value; OnPropertyChanged("PracticeSetting"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _PracticeSetting;
            
            /// <summary>
            /// Source patient info
            /// </summary>
            [FhirElement("sourcePatientInfo", InSummary=true, Order=90)]
            [References("Patient")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference SourcePatientInfo
            {
                get { return _SourcePatientInfo; }
                set { _SourcePatientInfo = value; OnPropertyChanged("SourcePatientInfo"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _SourcePatientInfo;
            
            /// <summary>
            /// Related identifiers or resources
            /// </summary>
            [FhirElement("related", InSummary=true, Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.DocumentReference.DocumentReferenceContextRelatedComponent> Related
            {
                get { if(_Related==null) _Related = new List<Hl7.Fhir.Model.DocumentReference.DocumentReferenceContextRelatedComponent>(); return _Related; }
                set { _Related = value; OnPropertyChanged("Related"); }
            }
            
            private List<Hl7.Fhir.Model.DocumentReference.DocumentReferenceContextRelatedComponent> _Related;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DocumentReferenceContextComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
                    if(Event != null) dest.Event = new List<Hl7.Fhir.Model.CodeableConcept>(Event.DeepCopy());
                    if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
                    if(FacilityType != null) dest.FacilityType = (Hl7.Fhir.Model.CodeableConcept)FacilityType.DeepCopy();
                    if(PracticeSetting != null) dest.PracticeSetting = (Hl7.Fhir.Model.CodeableConcept)PracticeSetting.DeepCopy();
                    if(SourcePatientInfo != null) dest.SourcePatientInfo = (Hl7.Fhir.Model.ResourceReference)SourcePatientInfo.DeepCopy();
                    if(Related != null) dest.Related = new List<Hl7.Fhir.Model.DocumentReference.DocumentReferenceContextRelatedComponent>(Related.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new DocumentReferenceContextComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DocumentReferenceContextComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
                if( !DeepComparable.Matches(Event, otherT.Event)) return false;
                if( !DeepComparable.Matches(Period, otherT.Period)) return false;
                if( !DeepComparable.Matches(FacilityType, otherT.FacilityType)) return false;
                if( !DeepComparable.Matches(PracticeSetting, otherT.PracticeSetting)) return false;
                if( !DeepComparable.Matches(SourcePatientInfo, otherT.SourcePatientInfo)) return false;
                if( !DeepComparable.Matches(Related, otherT.Related)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DocumentReferenceContextComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
                if( !DeepComparable.IsExactly(Event, otherT.Event)) return false;
                if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if( !DeepComparable.IsExactly(FacilityType, otherT.FacilityType)) return false;
                if( !DeepComparable.IsExactly(PracticeSetting, otherT.PracticeSetting)) return false;
                if( !DeepComparable.IsExactly(SourcePatientInfo, otherT.SourcePatientInfo)) return false;
                if( !DeepComparable.IsExactly(Related, otherT.Related)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("DocumentReferenceRelatesToComponent")]
        [DataContract]
        public partial class DocumentReferenceRelatesToComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DocumentReferenceRelatesToComponent"; } }
            
            /// <summary>
            /// replaces | transforms | signs | appends
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<Hl7.Fhir.Model.DocumentReference.DocumentRelationshipType> CodeElement
            {
                get { return _CodeElement; }
                set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
            }
            
            private Code<Hl7.Fhir.Model.DocumentReference.DocumentRelationshipType> _CodeElement;
            
            /// <summary>
            /// replaces | transforms | signs | appends
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.DocumentReference.DocumentRelationshipType? Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if(value == null)
                      CodeElement = null; 
                    else
                      CodeElement = new Code<Hl7.Fhir.Model.DocumentReference.DocumentRelationshipType>(value);
                    OnPropertyChanged("Code");
                }
            }
            
            /// <summary>
            /// Target of the relationship
            /// </summary>
            [FhirElement("target", InSummary=true, Order=50)]
            [References("DocumentReference")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Target
            {
                get { return _Target; }
                set { _Target = value; OnPropertyChanged("Target"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Target;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DocumentReferenceRelatesToComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(CodeElement != null) dest.CodeElement = (Code<Hl7.Fhir.Model.DocumentReference.DocumentRelationshipType>)CodeElement.DeepCopy();
                    if(Target != null) dest.Target = (Hl7.Fhir.Model.ResourceReference)Target.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new DocumentReferenceRelatesToComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DocumentReferenceRelatesToComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.Matches(Target, otherT.Target)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DocumentReferenceRelatesToComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.IsExactly(Target, otherT.Target)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("DocumentReferenceContextRelatedComponent")]
        [DataContract]
        public partial class DocumentReferenceContextRelatedComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DocumentReferenceContextRelatedComponent"; } }
            
            /// <summary>
            /// Related Identifier
            /// </summary>
            [FhirElement("identifier", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.Identifier Identifier
            {
                get { return _Identifier; }
                set { _Identifier = value; OnPropertyChanged("Identifier"); }
            }
            
            private Hl7.Fhir.Model.Identifier _Identifier;
            
            /// <summary>
            /// Related Resource
            /// </summary>
            [FhirElement("ref", InSummary=true, Order=50)]
            [References()]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Ref
            {
                get { return _Ref; }
                set { _Ref = value; OnPropertyChanged("Ref"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Ref;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DocumentReferenceContextRelatedComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.Identifier)Identifier.DeepCopy();
                    if(Ref != null) dest.Ref = (Hl7.Fhir.Model.ResourceReference)Ref.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new DocumentReferenceContextRelatedComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DocumentReferenceContextRelatedComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.Matches(Ref, otherT.Ref)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DocumentReferenceContextRelatedComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.IsExactly(Ref, otherT.Ref)) return false;
                
                return true;
            }
            
        }
        
        
        /// <summary>
        /// Master Version Specific Identifier
        /// </summary>
        [FhirElement("masterIdentifier", Order=90)]
        [DataMember]
        public Hl7.Fhir.Model.Identifier MasterIdentifier
        {
            get { return _MasterIdentifier; }
            set { _MasterIdentifier = value; OnPropertyChanged("MasterIdentifier"); }
        }
        
        private Hl7.Fhir.Model.Identifier _MasterIdentifier;
        
        /// <summary>
        /// Other identifiers for the document
        /// </summary>
        [FhirElement("identifier", Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// Who|what is the subject of the document
        /// </summary>
        [FhirElement("subject", Order=110)]
        [References("Patient","Practitioner","Group","Device")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Subject;
        
        /// <summary>
        /// Kind of document
        /// </summary>
        [FhirElement("type", Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Type;
        
        /// <summary>
        /// Categorization of document
        /// </summary>
        [FhirElement("class", Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Class
        {
            get { return _Class; }
            set { _Class = value; OnPropertyChanged("Class"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Class;
        
        /// <summary>
        /// Format/content rules for the document
        /// </summary>
        [FhirElement("format", Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Coding> Format
        {
            get { if(_Format==null) _Format = new List<Hl7.Fhir.Model.Coding>(); return _Format; }
            set { _Format = value; OnPropertyChanged("Format"); }
        }
        
        private List<Hl7.Fhir.Model.Coding> _Format;
        
        /// <summary>
        /// Who and/or what authored the document
        /// </summary>
        [FhirElement("author", Order=150)]
        [References("Practitioner","Organization","Device","Patient","RelatedPerson")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Author
        {
            get { if(_Author==null) _Author = new List<Hl7.Fhir.Model.ResourceReference>(); return _Author; }
            set { _Author = value; OnPropertyChanged("Author"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Author;
        
        /// <summary>
        /// Org which maintains the document
        /// </summary>
        [FhirElement("custodian", Order=160)]
        [References("Organization")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Custodian
        {
            get { return _Custodian; }
            set { _Custodian = value; OnPropertyChanged("Custodian"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Custodian;
        
        /// <summary>
        /// Who/What authenticated the document
        /// </summary>
        [FhirElement("authenticator", Order=170)]
        [References("Practitioner","Organization")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Authenticator
        {
            get { return _Authenticator; }
            set { _Authenticator = value; OnPropertyChanged("Authenticator"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Authenticator;
        
        /// <summary>
        /// Document creation time
        /// </summary>
        [FhirElement("created", Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime CreatedElement
        {
            get { return _CreatedElement; }
            set { _CreatedElement = value; OnPropertyChanged("CreatedElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _CreatedElement;
        
        /// <summary>
        /// Document creation time
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Created
        {
            get { return CreatedElement != null ? CreatedElement.Value : null; }
            set
            {
                if(value == null)
                  CreatedElement = null; 
                else
                  CreatedElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Created");
            }
        }
        
        /// <summary>
        /// When this document reference created
        /// </summary>
        [FhirElement("indexed", Order=190)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Instant IndexedElement
        {
            get { return _IndexedElement; }
            set { _IndexedElement = value; OnPropertyChanged("IndexedElement"); }
        }
        
        private Hl7.Fhir.Model.Instant _IndexedElement;
        
        /// <summary>
        /// When this document reference created
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public DateTimeOffset? Indexed
        {
            get { return IndexedElement != null ? IndexedElement.Value : null; }
            set
            {
                if(value == null)
                  IndexedElement = null; 
                else
                  IndexedElement = new Hl7.Fhir.Model.Instant(value);
                OnPropertyChanged("Indexed");
            }
        }
        
        /// <summary>
        /// current | superseded | entered-in-error
        /// </summary>
        [FhirElement("status", Order=200)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.DocumentReferenceStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.DocumentReferenceStatus> _StatusElement;
        
        /// <summary>
        /// current | superseded | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.DocumentReferenceStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.DocumentReferenceStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// preliminary | final | appended | amended | entered-in-error
        /// </summary>
        [FhirElement("docStatus", Order=210)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept DocStatus
        {
            get { return _DocStatus; }
            set { _DocStatus = value; OnPropertyChanged("DocStatus"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _DocStatus;
        
        /// <summary>
        /// Relationships to other documents
        /// </summary>
        [FhirElement("relatesTo", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.DocumentReference.DocumentReferenceRelatesToComponent> RelatesTo
        {
            get { if(_RelatesTo==null) _RelatesTo = new List<Hl7.Fhir.Model.DocumentReference.DocumentReferenceRelatesToComponent>(); return _RelatesTo; }
            set { _RelatesTo = value; OnPropertyChanged("RelatesTo"); }
        }
        
        private List<Hl7.Fhir.Model.DocumentReference.DocumentReferenceRelatesToComponent> _RelatesTo;
        
        /// <summary>
        /// Human-readable description (title)
        /// </summary>
        [FhirElement("description", Order=230)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _DescriptionElement;
        
        /// <summary>
        /// Human-readable description (title)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if(value == null)
                  DescriptionElement = null; 
                else
                  DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Description");
            }
        }
        
        /// <summary>
        /// Document security-tags
        /// </summary>
        [FhirElement("securityLabel", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> SecurityLabel
        {
            get { if(_SecurityLabel==null) _SecurityLabel = new List<Hl7.Fhir.Model.CodeableConcept>(); return _SecurityLabel; }
            set { _SecurityLabel = value; OnPropertyChanged("SecurityLabel"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _SecurityLabel;
        
        /// <summary>
        /// Where to access the document
        /// </summary>
        [FhirElement("content", Order=250)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Attachment> Content
        {
            get { if(_Content==null) _Content = new List<Hl7.Fhir.Model.Attachment>(); return _Content; }
            set { _Content = value; OnPropertyChanged("Content"); }
        }
        
        private List<Hl7.Fhir.Model.Attachment> _Content;
        
        /// <summary>
        /// Clinical context of document
        /// </summary>
        [FhirElement("context", Order=260)]
        [DataMember]
        public Hl7.Fhir.Model.DocumentReference.DocumentReferenceContextComponent Context
        {
            get { return _Context; }
            set { _Context = value; OnPropertyChanged("Context"); }
        }
        
        private Hl7.Fhir.Model.DocumentReference.DocumentReferenceContextComponent _Context;
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as DocumentReference;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(MasterIdentifier != null) dest.MasterIdentifier = (Hl7.Fhir.Model.Identifier)MasterIdentifier.DeepCopy();
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
                if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                if(Class != null) dest.Class = (Hl7.Fhir.Model.CodeableConcept)Class.DeepCopy();
                if(Format != null) dest.Format = new List<Hl7.Fhir.Model.Coding>(Format.DeepCopy());
                if(Author != null) dest.Author = new List<Hl7.Fhir.Model.ResourceReference>(Author.DeepCopy());
                if(Custodian != null) dest.Custodian = (Hl7.Fhir.Model.ResourceReference)Custodian.DeepCopy();
                if(Authenticator != null) dest.Authenticator = (Hl7.Fhir.Model.ResourceReference)Authenticator.DeepCopy();
                if(CreatedElement != null) dest.CreatedElement = (Hl7.Fhir.Model.FhirDateTime)CreatedElement.DeepCopy();
                if(IndexedElement != null) dest.IndexedElement = (Hl7.Fhir.Model.Instant)IndexedElement.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.DocumentReferenceStatus>)StatusElement.DeepCopy();
                if(DocStatus != null) dest.DocStatus = (Hl7.Fhir.Model.CodeableConcept)DocStatus.DeepCopy();
                if(RelatesTo != null) dest.RelatesTo = new List<Hl7.Fhir.Model.DocumentReference.DocumentReferenceRelatesToComponent>(RelatesTo.DeepCopy());
                if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                if(SecurityLabel != null) dest.SecurityLabel = new List<Hl7.Fhir.Model.CodeableConcept>(SecurityLabel.DeepCopy());
                if(Content != null) dest.Content = new List<Hl7.Fhir.Model.Attachment>(Content.DeepCopy());
                if(Context != null) dest.Context = (Hl7.Fhir.Model.DocumentReference.DocumentReferenceContextComponent)Context.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new DocumentReference());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as DocumentReference;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(MasterIdentifier, otherT.MasterIdentifier)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(Class, otherT.Class)) return false;
            if( !DeepComparable.Matches(Format, otherT.Format)) return false;
            if( !DeepComparable.Matches(Author, otherT.Author)) return false;
            if( !DeepComparable.Matches(Custodian, otherT.Custodian)) return false;
            if( !DeepComparable.Matches(Authenticator, otherT.Authenticator)) return false;
            if( !DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if( !DeepComparable.Matches(IndexedElement, otherT.IndexedElement)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(DocStatus, otherT.DocStatus)) return false;
            if( !DeepComparable.Matches(RelatesTo, otherT.RelatesTo)) return false;
            if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.Matches(SecurityLabel, otherT.SecurityLabel)) return false;
            if( !DeepComparable.Matches(Content, otherT.Content)) return false;
            if( !DeepComparable.Matches(Context, otherT.Context)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DocumentReference;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(MasterIdentifier, otherT.MasterIdentifier)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(Class, otherT.Class)) return false;
            if( !DeepComparable.IsExactly(Format, otherT.Format)) return false;
            if( !DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if( !DeepComparable.IsExactly(Custodian, otherT.Custodian)) return false;
            if( !DeepComparable.IsExactly(Authenticator, otherT.Authenticator)) return false;
            if( !DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if( !DeepComparable.IsExactly(IndexedElement, otherT.IndexedElement)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(DocStatus, otherT.DocStatus)) return false;
            if( !DeepComparable.IsExactly(RelatesTo, otherT.RelatesTo)) return false;
            if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.IsExactly(SecurityLabel, otherT.SecurityLabel)) return false;
            if( !DeepComparable.IsExactly(Content, otherT.Content)) return false;
            if( !DeepComparable.IsExactly(Context, otherT.Context)) return false;
            
            return true;
        }
        
    }
    
}
