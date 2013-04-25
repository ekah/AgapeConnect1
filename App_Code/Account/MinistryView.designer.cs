﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MinistryView
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AgapeConnect")]
	public partial class MinistryViewDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMinistryView_UserCountryProfile(MinistryView_UserCountryProfile instance);
    partial void UpdateMinistryView_UserCountryProfile(MinistryView_UserCountryProfile instance);
    partial void DeleteMinistryView_UserCountryProfile(MinistryView_UserCountryProfile instance);
    partial void InsertMinistryView_AdditionalCountry(MinistryView_AdditionalCountry instance);
    partial void UpdateMinistryView_AdditionalCountry(MinistryView_AdditionalCountry instance);
    partial void DeleteMinistryView_AdditionalCountry(MinistryView_AdditionalCountry instance);
    #endregion
		
		public MinistryViewDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SiteSqlServer"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MinistryViewDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MinistryViewDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MinistryViewDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MinistryViewDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MinistryView_UserCountryProfile> MinistryView_UserCountryProfiles
		{
			get
			{
				return this.GetTable<MinistryView_UserCountryProfile>();
			}
		}
		
		public System.Data.Linq.Table<MinistryView_AdditionalCountry> MinistryView_AdditionalCountries
		{
			get
			{
				return this.GetTable<MinistryView_AdditionalCountry>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MinistryView_UserCountryProfile")]
	public partial class MinistryView_UserCountryProfile : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserCountryProfileId;
		
		private int _CountryId;
		
		private string _Username;
		
		private string _Password;
		
		private string _GUID;
		
		private EntityRef<MinistryView_AdditionalCountry> _MinistryView_AdditionalCountry;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserCountryProfileIdChanging(int value);
    partial void OnUserCountryProfileIdChanged();
    partial void OnCountryIdChanging(int value);
    partial void OnCountryIdChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnGUIDChanging(string value);
    partial void OnGUIDChanged();
    #endregion
		
		public MinistryView_UserCountryProfile()
		{
			this._MinistryView_AdditionalCountry = default(EntityRef<MinistryView_AdditionalCountry>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserCountryProfileId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserCountryProfileId
		{
			get
			{
				return this._UserCountryProfileId;
			}
			set
			{
				if ((this._UserCountryProfileId != value))
				{
					this.OnUserCountryProfileIdChanging(value);
					this.SendPropertyChanging();
					this._UserCountryProfileId = value;
					this.SendPropertyChanged("UserCountryProfileId");
					this.OnUserCountryProfileIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryId", DbType="Int NOT NULL")]
		public int CountryId
		{
			get
			{
				return this._CountryId;
			}
			set
			{
				if ((this._CountryId != value))
				{
					if (this._MinistryView_AdditionalCountry.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCountryIdChanging(value);
					this.SendPropertyChanging();
					this._CountryId = value;
					this.SendPropertyChanged("CountryId");
					this.OnCountryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GUID", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string GUID
		{
			get
			{
				return this._GUID;
			}
			set
			{
				if ((this._GUID != value))
				{
					this.OnGUIDChanging(value);
					this.SendPropertyChanging();
					this._GUID = value;
					this.SendPropertyChanged("GUID");
					this.OnGUIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MinistryView_AdditionalCountry_MinistryView_UserCountryProfile", Storage="_MinistryView_AdditionalCountry", ThisKey="CountryId", OtherKey="CountryId", IsForeignKey=true)]
		public MinistryView_AdditionalCountry MinistryView_AdditionalCountry
		{
			get
			{
				return this._MinistryView_AdditionalCountry.Entity;
			}
			set
			{
				MinistryView_AdditionalCountry previousValue = this._MinistryView_AdditionalCountry.Entity;
				if (((previousValue != value) 
							|| (this._MinistryView_AdditionalCountry.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MinistryView_AdditionalCountry.Entity = null;
						previousValue.MinistryView_UserCountryProfiles.Remove(this);
					}
					this._MinistryView_AdditionalCountry.Entity = value;
					if ((value != null))
					{
						value.MinistryView_UserCountryProfiles.Add(this);
						this._CountryId = value.CountryId;
					}
					else
					{
						this._CountryId = default(int);
					}
					this.SendPropertyChanged("MinistryView_AdditionalCountry");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MinistryView_AdditionalCountries")]
	public partial class MinistryView_AdditionalCountry : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CountryId;
		
		private string _CountryName;
		
		private string _ServiceURL;
		
		private EntitySet<MinistryView_UserCountryProfile> _MinistryView_UserCountryProfiles;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCountryIdChanging(int value);
    partial void OnCountryIdChanged();
    partial void OnCountryNameChanging(string value);
    partial void OnCountryNameChanged();
    partial void OnServiceURLChanging(string value);
    partial void OnServiceURLChanged();
    #endregion
		
		public MinistryView_AdditionalCountry()
		{
			this._MinistryView_UserCountryProfiles = new EntitySet<MinistryView_UserCountryProfile>(new Action<MinistryView_UserCountryProfile>(this.attach_MinistryView_UserCountryProfiles), new Action<MinistryView_UserCountryProfile>(this.detach_MinistryView_UserCountryProfiles));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CountryId
		{
			get
			{
				return this._CountryId;
			}
			set
			{
				if ((this._CountryId != value))
				{
					this.OnCountryIdChanging(value);
					this.SendPropertyChanging();
					this._CountryId = value;
					this.SendPropertyChanged("CountryId");
					this.OnCountryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryName", DbType="NVarChar(100)")]
		public string CountryName
		{
			get
			{
				return this._CountryName;
			}
			set
			{
				if ((this._CountryName != value))
				{
					this.OnCountryNameChanging(value);
					this.SendPropertyChanging();
					this._CountryName = value;
					this.SendPropertyChanged("CountryName");
					this.OnCountryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceURL", DbType="NVarChar(250)")]
		public string ServiceURL
		{
			get
			{
				return this._ServiceURL;
			}
			set
			{
				if ((this._ServiceURL != value))
				{
					this.OnServiceURLChanging(value);
					this.SendPropertyChanging();
					this._ServiceURL = value;
					this.SendPropertyChanged("ServiceURL");
					this.OnServiceURLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MinistryView_AdditionalCountry_MinistryView_UserCountryProfile", Storage="_MinistryView_UserCountryProfiles", ThisKey="CountryId", OtherKey="CountryId")]
		public EntitySet<MinistryView_UserCountryProfile> MinistryView_UserCountryProfiles
		{
			get
			{
				return this._MinistryView_UserCountryProfiles;
			}
			set
			{
				this._MinistryView_UserCountryProfiles.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_MinistryView_UserCountryProfiles(MinistryView_UserCountryProfile entity)
		{
			this.SendPropertyChanging();
			entity.MinistryView_AdditionalCountry = this;
		}
		
		private void detach_MinistryView_UserCountryProfiles(MinistryView_UserCountryProfile entity)
		{
			this.SendPropertyChanging();
			entity.MinistryView_AdditionalCountry = null;
		}
	}
}
#pragma warning restore 1591