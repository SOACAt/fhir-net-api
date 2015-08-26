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
    /// A photo, video, or audio recording acquired or used in healthcare. The actual content may be inline or provided by direct reference
    /// </summary>
    [FhirType("Media", IsResource=true)]
    [DataContract]
    public partial class Media : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Media; } }
        [NotMapped]
        public override string TypeName { get { return "Media"; } }
        
        /// <summary>
        /// Whether the Media is a photo, video, or audio
        /// </summary>
        [FhirEnumeration("DigitalMediaType")]
        public enum DigitalMediaType
        {
            /// <summary>
            /// The media consists of one or more unmoving images, including photographs, computer-generated graphs and charts, and scanned documents
            /// </summary>
            [EnumLiteral("photo")]
            Photo,
            /// <summary>
            /// The media consists of a series of frames that capture a moving image
            /// </summary>
            [EnumLiteral("video")]
            Video,
            /// <summary>
            /// The media consists of a sound recording
            /// </summary>
            [EnumLiteral("audio")]
            Audio,
        }
        
        /// <summary>
        /// photo | video | audio
        /// </summary>
        [FhirElement("type", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.Media.DigitalMediaType> TypeElement
        {
            get { return _TypeElement; }
            set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
        }
        
        private Code<Hl7.Fhir.Model.Media.DigitalMediaType> _TypeElement;
        
        /// <summary>
        /// photo | video | audio
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.Media.DigitalMediaType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if(value == null)
                  TypeElement = null; 
                else
                  TypeElement = new Code<Hl7.Fhir.Model.Media.DigitalMediaType>(value);
                OnPropertyChanged("Type");
            }
        }
        
        /// <summary>
        /// The type of acquisition equipment/process
        /// </summary>
        [FhirElement("subtype", InSummary=true, Order=100)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Subtype
        {
            get { return _Subtype; }
            set { _Subtype = value; OnPropertyChanged("Subtype"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Subtype;
        
        /// <summary>
        /// Identifier(s) for the image
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// Who/What this Media is a record of
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=120)]
        [References("Patient","Practitioner","Group","Device","Specimen")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Subject;
        
        /// <summary>
        /// The person who generated the image
        /// </summary>
        [FhirElement("operator", InSummary=true, Order=130)]
        [References("Practitioner")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Operator
        {
            get { return _Operator; }
            set { _Operator = value; OnPropertyChanged("Operator"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Operator;
        
        /// <summary>
        /// Imaging view e.g Lateral or Antero-posterior
        /// </summary>
        [FhirElement("view", InSummary=true, Order=140)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept View
        {
            get { return _View; }
            set { _View = value; OnPropertyChanged("View"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _View;
        
        /// <summary>
        /// Name of the device/manufacturer
        /// </summary>
        [FhirElement("deviceName", InSummary=true, Order=150)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DeviceNameElement
        {
            get { return _DeviceNameElement; }
            set { _DeviceNameElement = value; OnPropertyChanged("DeviceNameElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _DeviceNameElement;
        
        /// <summary>
        /// Name of the device/manufacturer
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string DeviceName
        {
            get { return DeviceNameElement != null ? DeviceNameElement.Value : null; }
            set
            {
                if(value == null)
                  DeviceNameElement = null; 
                else
                  DeviceNameElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("DeviceName");
            }
        }
        
        /// <summary>
        /// Height of the image in pixels(photo/video)
        /// </summary>
        [FhirElement("height", InSummary=true, Order=160)]
        [DataMember]
        public Hl7.Fhir.Model.PositiveInt HeightElement
        {
            get { return _HeightElement; }
            set { _HeightElement = value; OnPropertyChanged("HeightElement"); }
        }
        
        private Hl7.Fhir.Model.PositiveInt _HeightElement;
        
        /// <summary>
        /// Height of the image in pixels(photo/video)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public int? Height
        {
            get { return HeightElement != null ? HeightElement.Value : null; }
            set
            {
                if(value == null)
                  HeightElement = null; 
                else
                  HeightElement = new Hl7.Fhir.Model.PositiveInt(value);
                OnPropertyChanged("Height");
            }
        }
        
        /// <summary>
        /// Width of the image in pixels (photo/video)
        /// </summary>
        [FhirElement("width", InSummary=true, Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.PositiveInt WidthElement
        {
            get { return _WidthElement; }
            set { _WidthElement = value; OnPropertyChanged("WidthElement"); }
        }
        
        private Hl7.Fhir.Model.PositiveInt _WidthElement;
        
        /// <summary>
        /// Width of the image in pixels (photo/video)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public int? Width
        {
            get { return WidthElement != null ? WidthElement.Value : null; }
            set
            {
                if(value == null)
                  WidthElement = null; 
                else
                  WidthElement = new Hl7.Fhir.Model.PositiveInt(value);
                OnPropertyChanged("Width");
            }
        }
        
        /// <summary>
        /// Number of frames if &gt; 1 (photo)
        /// </summary>
        [FhirElement("frames", InSummary=true, Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.PositiveInt FramesElement
        {
            get { return _FramesElement; }
            set { _FramesElement = value; OnPropertyChanged("FramesElement"); }
        }
        
        private Hl7.Fhir.Model.PositiveInt _FramesElement;
        
        /// <summary>
        /// Number of frames if &gt; 1 (photo)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public int? Frames
        {
            get { return FramesElement != null ? FramesElement.Value : null; }
            set
            {
                if(value == null)
                  FramesElement = null; 
                else
                  FramesElement = new Hl7.Fhir.Model.PositiveInt(value);
                OnPropertyChanged("Frames");
            }
        }
        
        /// <summary>
        /// Length in seconds (audio / video)
        /// </summary>
        [FhirElement("duration", InSummary=true, Order=190)]
        [DataMember]
        public Hl7.Fhir.Model.UnsignedInt DurationElement
        {
            get { return _DurationElement; }
            set { _DurationElement = value; OnPropertyChanged("DurationElement"); }
        }
        
        private Hl7.Fhir.Model.UnsignedInt _DurationElement;
        
        /// <summary>
        /// Length in seconds (audio / video)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public int? Duration
        {
            get { return DurationElement != null ? DurationElement.Value : null; }
            set
            {
                if(value == null)
                  DurationElement = null; 
                else
                  DurationElement = new Hl7.Fhir.Model.UnsignedInt(value);
                OnPropertyChanged("Duration");
            }
        }
        
        /// <summary>
        /// Actual Media - reference or data
        /// </summary>
        [FhirElement("content", Order=200)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Attachment Content
        {
            get { return _Content; }
            set { _Content = value; OnPropertyChanged("Content"); }
        }
        
        private Hl7.Fhir.Model.Attachment _Content;
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Media;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(TypeElement != null) dest.TypeElement = (Code<Hl7.Fhir.Model.Media.DigitalMediaType>)TypeElement.DeepCopy();
                if(Subtype != null) dest.Subtype = (Hl7.Fhir.Model.CodeableConcept)Subtype.DeepCopy();
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
                if(Operator != null) dest.Operator = (Hl7.Fhir.Model.ResourceReference)Operator.DeepCopy();
                if(View != null) dest.View = (Hl7.Fhir.Model.CodeableConcept)View.DeepCopy();
                if(DeviceNameElement != null) dest.DeviceNameElement = (Hl7.Fhir.Model.FhirString)DeviceNameElement.DeepCopy();
                if(HeightElement != null) dest.HeightElement = (Hl7.Fhir.Model.PositiveInt)HeightElement.DeepCopy();
                if(WidthElement != null) dest.WidthElement = (Hl7.Fhir.Model.PositiveInt)WidthElement.DeepCopy();
                if(FramesElement != null) dest.FramesElement = (Hl7.Fhir.Model.PositiveInt)FramesElement.DeepCopy();
                if(DurationElement != null) dest.DurationElement = (Hl7.Fhir.Model.UnsignedInt)DurationElement.DeepCopy();
                if(Content != null) dest.Content = (Hl7.Fhir.Model.Attachment)Content.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Media());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Media;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if( !DeepComparable.Matches(Subtype, otherT.Subtype)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(Operator, otherT.Operator)) return false;
            if( !DeepComparable.Matches(View, otherT.View)) return false;
            if( !DeepComparable.Matches(DeviceNameElement, otherT.DeviceNameElement)) return false;
            if( !DeepComparable.Matches(HeightElement, otherT.HeightElement)) return false;
            if( !DeepComparable.Matches(WidthElement, otherT.WidthElement)) return false;
            if( !DeepComparable.Matches(FramesElement, otherT.FramesElement)) return false;
            if( !DeepComparable.Matches(DurationElement, otherT.DurationElement)) return false;
            if( !DeepComparable.Matches(Content, otherT.Content)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Media;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if( !DeepComparable.IsExactly(Subtype, otherT.Subtype)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(Operator, otherT.Operator)) return false;
            if( !DeepComparable.IsExactly(View, otherT.View)) return false;
            if( !DeepComparable.IsExactly(DeviceNameElement, otherT.DeviceNameElement)) return false;
            if( !DeepComparable.IsExactly(HeightElement, otherT.HeightElement)) return false;
            if( !DeepComparable.IsExactly(WidthElement, otherT.WidthElement)) return false;
            if( !DeepComparable.IsExactly(FramesElement, otherT.FramesElement)) return false;
            if( !DeepComparable.IsExactly(DurationElement, otherT.DurationElement)) return false;
            if( !DeepComparable.IsExactly(Content, otherT.Content)) return false;
            
            return true;
        }
        
    }
    
}
