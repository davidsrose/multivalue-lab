﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace WebApplication_vs2010_oData
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class XDEMOEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new XDEMOEntities object using the connection string found in the 'XDEMOEntities' section of the application configuration file.
        /// </summary>
        public XDEMOEntities() : base("name=XDEMOEntities", "XDEMOEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new XDEMOEntities object.
        /// </summary>
        public XDEMOEntities(string connectionString) : base(connectionString, "XDEMOEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new XDEMOEntities object.
        /// </summary>
        public XDEMOEntities(EntityConnection connection) : base(connection, "XDEMOEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PRODUCT> PRODUCTS
        {
            get
            {
                if ((_PRODUCTS == null))
                {
                    _PRODUCTS = base.CreateObjectSet<PRODUCT>("PRODUCTS");
                }
                return _PRODUCTS;
            }
        }
        private ObjectSet<PRODUCT> _PRODUCTS;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PRODUCTS EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPRODUCTS(PRODUCT pRODUCT)
        {
            base.AddObject("PRODUCTS", pRODUCT);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="XDEMOModel", Name="PRODUCT")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PRODUCT : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PRODUCT object.
        /// </summary>
        /// <param name="pRODUCT_ID">Initial value of the PRODUCT_ID property.</param>
        /// <param name="l_UPC">Initial value of the L_UPC property.</param>
        /// <param name="lOCATION">Initial value of the LOCATION property.</param>
        public static PRODUCT CreatePRODUCT(global::System.Decimal pRODUCT_ID, global::System.String l_UPC, global::System.String lOCATION)
        {
            PRODUCT pRODUCT = new PRODUCT();
            pRODUCT.PRODUCT_ID = pRODUCT_ID;
            pRODUCT.L_UPC = l_UPC;
            pRODUCT.LOCATION = lOCATION;
            return pRODUCT;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal PRODUCT_ID
        {
            get
            {
                return _PRODUCT_ID;
            }
            set
            {
                if (_PRODUCT_ID != value)
                {
                    OnPRODUCT_IDChanging(value);
                    ReportPropertyChanging("PRODUCT_ID");
                    _PRODUCT_ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("PRODUCT_ID");
                    OnPRODUCT_IDChanged();
                }
            }
        }
        private global::System.Decimal _PRODUCT_ID;
        partial void OnPRODUCT_IDChanging(global::System.Decimal value);
        partial void OnPRODUCT_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ISBN
        {
            get
            {
                return _ISBN;
            }
            set
            {
                OnISBNChanging(value);
                ReportPropertyChanging("ISBN");
                _ISBN = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ISBN");
                OnISBNChanged();
            }
        }
        private global::System.String _ISBN;
        partial void OnISBNChanging(global::System.String value);
        partial void OnISBNChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TITLE
        {
            get
            {
                return _TITLE;
            }
            set
            {
                OnTITLEChanging(value);
                ReportPropertyChanging("TITLE");
                _TITLE = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TITLE");
                OnTITLEChanged();
            }
        }
        private global::System.String _TITLE;
        partial void OnTITLEChanging(global::System.String value);
        partial void OnTITLEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> DISKS
        {
            get
            {
                return _DISKS;
            }
            set
            {
                OnDISKSChanging(value);
                ReportPropertyChanging("DISKS");
                _DISKS = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DISKS");
                OnDISKSChanged();
            }
        }
        private Nullable<global::System.Int32> _DISKS;
        partial void OnDISKSChanging(Nullable<global::System.Int32> value);
        partial void OnDISKSChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String RATING
        {
            get
            {
                return _RATING;
            }
            set
            {
                OnRATINGChanging(value);
                ReportPropertyChanging("RATING");
                _RATING = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("RATING");
                OnRATINGChanged();
            }
        }
        private global::System.String _RATING;
        partial void OnRATINGChanging(global::System.String value);
        partial void OnRATINGChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> ASPECT
        {
            get
            {
                return _ASPECT;
            }
            set
            {
                OnASPECTChanging(value);
                ReportPropertyChanging("ASPECT");
                _ASPECT = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ASPECT");
                OnASPECTChanged();
            }
        }
        private Nullable<global::System.Decimal> _ASPECT;
        partial void OnASPECTChanging(Nullable<global::System.Decimal> value);
        partial void OnASPECTChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String GENRE
        {
            get
            {
                return _GENRE;
            }
            set
            {
                OnGENREChanging(value);
                ReportPropertyChanging("GENRE");
                _GENRE = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("GENRE");
                OnGENREChanged();
            }
        }
        private global::System.String _GENRE;
        partial void OnGENREChanging(global::System.String value);
        partial void OnGENREChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> NOEPISODES
        {
            get
            {
                return _NOEPISODES;
            }
            set
            {
                OnNOEPISODESChanging(value);
                ReportPropertyChanging("NOEPISODES");
                _NOEPISODES = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("NOEPISODES");
                OnNOEPISODESChanged();
            }
        }
        private Nullable<global::System.Int32> _NOEPISODES;
        partial void OnNOEPISODESChanging(Nullable<global::System.Int32> value);
        partial void OnNOEPISODESChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LOCATION_CODE
        {
            get
            {
                return _LOCATION_CODE;
            }
            set
            {
                OnLOCATION_CODEChanging(value);
                ReportPropertyChanging("LOCATION_CODE");
                _LOCATION_CODE = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LOCATION_CODE");
                OnLOCATION_CODEChanged();
            }
        }
        private global::System.String _LOCATION_CODE;
        partial void OnLOCATION_CODEChanging(global::System.String value);
        partial void OnLOCATION_CODEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> THEATERDATE
        {
            get
            {
                return _THEATERDATE;
            }
            set
            {
                OnTHEATERDATEChanging(value);
                ReportPropertyChanging("THEATERDATE");
                _THEATERDATE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("THEATERDATE");
                OnTHEATERDATEChanged();
            }
        }
        private Nullable<global::System.DateTime> _THEATERDATE;
        partial void OnTHEATERDATEChanging(Nullable<global::System.DateTime> value);
        partial void OnTHEATERDATEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MPN
        {
            get
            {
                return _MPN;
            }
            set
            {
                OnMPNChanging(value);
                ReportPropertyChanging("MPN");
                _MPN = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MPN");
                OnMPNChanged();
            }
        }
        private global::System.String _MPN;
        partial void OnMPNChanging(global::System.String value);
        partial void OnMPNChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String STUDIO
        {
            get
            {
                return _STUDIO;
            }
            set
            {
                OnSTUDIOChanging(value);
                ReportPropertyChanging("STUDIO");
                _STUDIO = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("STUDIO");
                OnSTUDIOChanged();
            }
        }
        private global::System.String _STUDIO;
        partial void OnSTUDIOChanging(global::System.String value);
        partial void OnSTUDIOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DVDRELDATE
        {
            get
            {
                return _DVDRELDATE;
            }
            set
            {
                OnDVDRELDATEChanging(value);
                ReportPropertyChanging("DVDRELDATE");
                _DVDRELDATE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DVDRELDATE");
                OnDVDRELDATEChanged();
            }
        }
        private Nullable<global::System.DateTime> _DVDRELDATE;
        partial void OnDVDRELDATEChanging(Nullable<global::System.DateTime> value);
        partial void OnDVDRELDATEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String L_UPC
        {
            get
            {
                return _L_UPC;
            }
            set
            {
                OnL_UPCChanging(value);
                ReportPropertyChanging("L_UPC");
                _L_UPC = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("L_UPC");
                OnL_UPCChanged();
            }
        }
        private global::System.String _L_UPC;
        partial void OnL_UPCChanging(global::System.String value);
        partial void OnL_UPCChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LOCATION
        {
            get
            {
                return _LOCATION;
            }
            set
            {
                OnLOCATIONChanging(value);
                ReportPropertyChanging("LOCATION");
                _LOCATION = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LOCATION");
                OnLOCATIONChanged();
            }
        }
        private global::System.String _LOCATION;
        partial void OnLOCATIONChanging(global::System.String value);
        partial void OnLOCATIONChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MOVIE_IMAGE
        {
            get
            {
                return _MOVIE_IMAGE;
            }
            set
            {
                OnMOVIE_IMAGEChanging(value);
                ReportPropertyChanging("MOVIE_IMAGE");
                _MOVIE_IMAGE = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MOVIE_IMAGE");
                OnMOVIE_IMAGEChanged();
            }
        }
        private global::System.String _MOVIE_IMAGE;
        partial void OnMOVIE_IMAGEChanging(global::System.String value);
        partial void OnMOVIE_IMAGEChanged();

        #endregion
    
    }

    #endregion
    
}
