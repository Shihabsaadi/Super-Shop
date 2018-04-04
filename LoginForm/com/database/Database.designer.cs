﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginForm.com.database
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="shopdb")]
	public partial class DatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertADMIN(ADMIN instance);
    partial void UpdateADMIN(ADMIN instance);
    partial void DeleteADMIN(ADMIN instance);
    partial void InsertCASHIER(CASHIER instance);
    partial void UpdateCASHIER(CASHIER instance);
    partial void DeleteCASHIER(CASHIER instance);
    partial void InsertSELL_ITEM(SELL_ITEM instance);
    partial void UpdateSELL_ITEM(SELL_ITEM instance);
    partial void DeleteSELL_ITEM(SELL_ITEM instance);
    partial void InsertPRODUCT(PRODUCT instance);
    partial void UpdatePRODUCT(PRODUCT instance);
    partial void DeletePRODUCT(PRODUCT instance);
    partial void InsertSUPPLIER(SUPPLIER instance);
    partial void UpdateSUPPLIER(SUPPLIER instance);
    partial void DeleteSUPPLIER(SUPPLIER instance);
    #endregion
		
		public DatabaseDataContext() : 
				base(global::LoginForm.Properties.Settings.Default.shopdbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ADMIN> ADMINs
		{
			get
			{
				return this.GetTable<ADMIN>();
			}
		}
		
		public System.Data.Linq.Table<CASHIER> CASHIERs
		{
			get
			{
				return this.GetTable<CASHIER>();
			}
		}
		
		public System.Data.Linq.Table<SELL_ITEM> SELL_ITEMs
		{
			get
			{
				return this.GetTable<SELL_ITEM>();
			}
		}
		
		public System.Data.Linq.Table<PRODUCT> PRODUCTs
		{
			get
			{
				return this.GetTable<PRODUCT>();
			}
		}
		
		public System.Data.Linq.Table<SUPPLIER> SUPPLIERs
		{
			get
			{
				return this.GetTable<SUPPLIER>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ADMIN")]
	public partial class ADMIN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ADMIN_ID;
		
		private string _NAME;
		
		private string _PHONE_NO;
		
		private string _PASSWORD;
		
		private EntitySet<CASHIER> _CASHIERs;
		
		private EntitySet<PRODUCT> _PRODUCTs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnADMIN_IDChanging(int value);
    partial void OnADMIN_IDChanged();
    partial void OnNAMEChanging(string value);
    partial void OnNAMEChanged();
    partial void OnPHONE_NOChanging(string value);
    partial void OnPHONE_NOChanged();
    partial void OnPASSWORDChanging(string value);
    partial void OnPASSWORDChanged();
    #endregion
		
		public ADMIN()
		{
			this._CASHIERs = new EntitySet<CASHIER>(new Action<CASHIER>(this.attach_CASHIERs), new Action<CASHIER>(this.detach_CASHIERs));
			this._PRODUCTs = new EntitySet<PRODUCT>(new Action<PRODUCT>(this.attach_PRODUCTs), new Action<PRODUCT>(this.detach_PRODUCTs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ADMIN_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ADMIN_ID
		{
			get
			{
				return this._ADMIN_ID;
			}
			set
			{
				if ((this._ADMIN_ID != value))
				{
					this.OnADMIN_IDChanging(value);
					this.SendPropertyChanging();
					this._ADMIN_ID = value;
					this.SendPropertyChanged("ADMIN_ID");
					this.OnADMIN_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NAME
		{
			get
			{
				return this._NAME;
			}
			set
			{
				if ((this._NAME != value))
				{
					this.OnNAMEChanging(value);
					this.SendPropertyChanging();
					this._NAME = value;
					this.SendPropertyChanged("NAME");
					this.OnNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PHONE_NO", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PHONE_NO
		{
			get
			{
				return this._PHONE_NO;
			}
			set
			{
				if ((this._PHONE_NO != value))
				{
					this.OnPHONE_NOChanging(value);
					this.SendPropertyChanging();
					this._PHONE_NO = value;
					this.SendPropertyChanged("PHONE_NO");
					this.OnPHONE_NOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PASSWORD", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PASSWORD
		{
			get
			{
				return this._PASSWORD;
			}
			set
			{
				if ((this._PASSWORD != value))
				{
					this.OnPASSWORDChanging(value);
					this.SendPropertyChanging();
					this._PASSWORD = value;
					this.SendPropertyChanged("PASSWORD");
					this.OnPASSWORDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ADMIN_CASHIER", Storage="_CASHIERs", ThisKey="ADMIN_ID", OtherKey="ADMIN_ID")]
		public EntitySet<CASHIER> CASHIERs
		{
			get
			{
				return this._CASHIERs;
			}
			set
			{
				this._CASHIERs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ADMIN_PRODUCT", Storage="_PRODUCTs", ThisKey="ADMIN_ID", OtherKey="ADMIN_ID")]
		public EntitySet<PRODUCT> PRODUCTs
		{
			get
			{
				return this._PRODUCTs;
			}
			set
			{
				this._PRODUCTs.Assign(value);
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
		
		private void attach_CASHIERs(CASHIER entity)
		{
			this.SendPropertyChanging();
			entity.ADMIN = this;
		}
		
		private void detach_CASHIERs(CASHIER entity)
		{
			this.SendPropertyChanging();
			entity.ADMIN = null;
		}
		
		private void attach_PRODUCTs(PRODUCT entity)
		{
			this.SendPropertyChanging();
			entity.ADMIN = this;
		}
		
		private void detach_PRODUCTs(PRODUCT entity)
		{
			this.SendPropertyChanging();
			entity.ADMIN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CASHIER")]
	public partial class CASHIER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CASHIER_ID;
		
		private int _ADMIN_ID;
		
		private string _PASSWORD;
		
		private string _DATE;
		
		private string _PHONE_NO;
		
		private string _ADDRESS;
		
		private double _SALARY;
		
		private string _EMAIL;
		
		private string _NAME;
		
		private EntitySet<SELL_ITEM> _SELL_ITEMs;
		
		private EntityRef<ADMIN> _ADMIN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCASHIER_IDChanging(int value);
    partial void OnCASHIER_IDChanged();
    partial void OnADMIN_IDChanging(int value);
    partial void OnADMIN_IDChanged();
    partial void OnPASSWORDChanging(string value);
    partial void OnPASSWORDChanged();
    partial void OnDATEChanging(string value);
    partial void OnDATEChanged();
    partial void OnPHONE_NOChanging(string value);
    partial void OnPHONE_NOChanged();
    partial void OnADDRESSChanging(string value);
    partial void OnADDRESSChanged();
    partial void OnSALARYChanging(double value);
    partial void OnSALARYChanged();
    partial void OnEMAILChanging(string value);
    partial void OnEMAILChanged();
    partial void OnNAMEChanging(string value);
    partial void OnNAMEChanged();
    #endregion
		
		public CASHIER()
		{
			this._SELL_ITEMs = new EntitySet<SELL_ITEM>(new Action<SELL_ITEM>(this.attach_SELL_ITEMs), new Action<SELL_ITEM>(this.detach_SELL_ITEMs));
			this._ADMIN = default(EntityRef<ADMIN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CASHIER_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CASHIER_ID
		{
			get
			{
				return this._CASHIER_ID;
			}
			set
			{
				if ((this._CASHIER_ID != value))
				{
					this.OnCASHIER_IDChanging(value);
					this.SendPropertyChanging();
					this._CASHIER_ID = value;
					this.SendPropertyChanged("CASHIER_ID");
					this.OnCASHIER_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ADMIN_ID", DbType="Int NOT NULL")]
		public int ADMIN_ID
		{
			get
			{
				return this._ADMIN_ID;
			}
			set
			{
				if ((this._ADMIN_ID != value))
				{
					if (this._ADMIN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnADMIN_IDChanging(value);
					this.SendPropertyChanging();
					this._ADMIN_ID = value;
					this.SendPropertyChanged("ADMIN_ID");
					this.OnADMIN_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PASSWORD", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PASSWORD
		{
			get
			{
				return this._PASSWORD;
			}
			set
			{
				if ((this._PASSWORD != value))
				{
					this.OnPASSWORDChanging(value);
					this.SendPropertyChanging();
					this._PASSWORD = value;
					this.SendPropertyChanged("PASSWORD");
					this.OnPASSWORDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATE", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DATE
		{
			get
			{
				return this._DATE;
			}
			set
			{
				if ((this._DATE != value))
				{
					this.OnDATEChanging(value);
					this.SendPropertyChanging();
					this._DATE = value;
					this.SendPropertyChanged("DATE");
					this.OnDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PHONE_NO", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PHONE_NO
		{
			get
			{
				return this._PHONE_NO;
			}
			set
			{
				if ((this._PHONE_NO != value))
				{
					this.OnPHONE_NOChanging(value);
					this.SendPropertyChanging();
					this._PHONE_NO = value;
					this.SendPropertyChanged("PHONE_NO");
					this.OnPHONE_NOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ADDRESS", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ADDRESS
		{
			get
			{
				return this._ADDRESS;
			}
			set
			{
				if ((this._ADDRESS != value))
				{
					this.OnADDRESSChanging(value);
					this.SendPropertyChanging();
					this._ADDRESS = value;
					this.SendPropertyChanged("ADDRESS");
					this.OnADDRESSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SALARY", DbType="Float NOT NULL")]
		public double SALARY
		{
			get
			{
				return this._SALARY;
			}
			set
			{
				if ((this._SALARY != value))
				{
					this.OnSALARYChanging(value);
					this.SendPropertyChanging();
					this._SALARY = value;
					this.SendPropertyChanged("SALARY");
					this.OnSALARYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMAIL", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EMAIL
		{
			get
			{
				return this._EMAIL;
			}
			set
			{
				if ((this._EMAIL != value))
				{
					this.OnEMAILChanging(value);
					this.SendPropertyChanging();
					this._EMAIL = value;
					this.SendPropertyChanged("EMAIL");
					this.OnEMAILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NAME
		{
			get
			{
				return this._NAME;
			}
			set
			{
				if ((this._NAME != value))
				{
					this.OnNAMEChanging(value);
					this.SendPropertyChanging();
					this._NAME = value;
					this.SendPropertyChanged("NAME");
					this.OnNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CASHIER_SELL_ITEM", Storage="_SELL_ITEMs", ThisKey="CASHIER_ID", OtherKey="CASHIER_ID")]
		public EntitySet<SELL_ITEM> SELL_ITEMs
		{
			get
			{
				return this._SELL_ITEMs;
			}
			set
			{
				this._SELL_ITEMs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ADMIN_CASHIER", Storage="_ADMIN", ThisKey="ADMIN_ID", OtherKey="ADMIN_ID", IsForeignKey=true)]
		public ADMIN ADMIN
		{
			get
			{
				return this._ADMIN.Entity;
			}
			set
			{
				ADMIN previousValue = this._ADMIN.Entity;
				if (((previousValue != value) 
							|| (this._ADMIN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ADMIN.Entity = null;
						previousValue.CASHIERs.Remove(this);
					}
					this._ADMIN.Entity = value;
					if ((value != null))
					{
						value.CASHIERs.Add(this);
						this._ADMIN_ID = value.ADMIN_ID;
					}
					else
					{
						this._ADMIN_ID = default(int);
					}
					this.SendPropertyChanged("ADMIN");
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
		
		private void attach_SELL_ITEMs(SELL_ITEM entity)
		{
			this.SendPropertyChanging();
			entity.CASHIER = this;
		}
		
		private void detach_SELL_ITEMs(SELL_ITEM entity)
		{
			this.SendPropertyChanging();
			entity.CASHIER = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SELL_ITEM")]
	public partial class SELL_ITEM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SELLING_ID;
		
		private int _PRODUCT_ID;
		
		private double _QUNATITY;
		
		private int _CASHIER_ID;
		
		private string _DATE;
		
		private double _PURCHASE;
		
		private double _SELLING_PRICE;
		
		private double _PROFIT;
		
		private EntityRef<CASHIER> _CASHIER;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSELLING_IDChanging(int value);
    partial void OnSELLING_IDChanged();
    partial void OnPRODUCT_IDChanging(int value);
    partial void OnPRODUCT_IDChanged();
    partial void OnQUNATITYChanging(double value);
    partial void OnQUNATITYChanged();
    partial void OnCASHIER_IDChanging(int value);
    partial void OnCASHIER_IDChanged();
    partial void OnDATEChanging(string value);
    partial void OnDATEChanged();
    partial void OnPURCHASEChanging(double value);
    partial void OnPURCHASEChanged();
    partial void OnSELLING_PRICEChanging(double value);
    partial void OnSELLING_PRICEChanged();
    partial void OnPROFITChanging(double value);
    partial void OnPROFITChanged();
    #endregion
		
		public SELL_ITEM()
		{
			this._CASHIER = default(EntityRef<CASHIER>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SELLING_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SELLING_ID
		{
			get
			{
				return this._SELLING_ID;
			}
			set
			{
				if ((this._SELLING_ID != value))
				{
					this.OnSELLING_IDChanging(value);
					this.SendPropertyChanging();
					this._SELLING_ID = value;
					this.SendPropertyChanged("SELLING_ID");
					this.OnSELLING_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PRODUCT_ID", DbType="Int NOT NULL")]
		public int PRODUCT_ID
		{
			get
			{
				return this._PRODUCT_ID;
			}
			set
			{
				if ((this._PRODUCT_ID != value))
				{
					this.OnPRODUCT_IDChanging(value);
					this.SendPropertyChanging();
					this._PRODUCT_ID = value;
					this.SendPropertyChanged("PRODUCT_ID");
					this.OnPRODUCT_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QUNATITY", DbType="Float NOT NULL")]
		public double QUNATITY
		{
			get
			{
				return this._QUNATITY;
			}
			set
			{
				if ((this._QUNATITY != value))
				{
					this.OnQUNATITYChanging(value);
					this.SendPropertyChanging();
					this._QUNATITY = value;
					this.SendPropertyChanged("QUNATITY");
					this.OnQUNATITYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CASHIER_ID", DbType="Int NOT NULL")]
		public int CASHIER_ID
		{
			get
			{
				return this._CASHIER_ID;
			}
			set
			{
				if ((this._CASHIER_ID != value))
				{
					if (this._CASHIER.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCASHIER_IDChanging(value);
					this.SendPropertyChanging();
					this._CASHIER_ID = value;
					this.SendPropertyChanged("CASHIER_ID");
					this.OnCASHIER_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATE", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DATE
		{
			get
			{
				return this._DATE;
			}
			set
			{
				if ((this._DATE != value))
				{
					this.OnDATEChanging(value);
					this.SendPropertyChanging();
					this._DATE = value;
					this.SendPropertyChanged("DATE");
					this.OnDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PURCHASE", DbType="Float NOT NULL")]
		public double PURCHASE
		{
			get
			{
				return this._PURCHASE;
			}
			set
			{
				if ((this._PURCHASE != value))
				{
					this.OnPURCHASEChanging(value);
					this.SendPropertyChanging();
					this._PURCHASE = value;
					this.SendPropertyChanged("PURCHASE");
					this.OnPURCHASEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SELLING_PRICE", DbType="Float NOT NULL")]
		public double SELLING_PRICE
		{
			get
			{
				return this._SELLING_PRICE;
			}
			set
			{
				if ((this._SELLING_PRICE != value))
				{
					this.OnSELLING_PRICEChanging(value);
					this.SendPropertyChanging();
					this._SELLING_PRICE = value;
					this.SendPropertyChanged("SELLING_PRICE");
					this.OnSELLING_PRICEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROFIT", DbType="Float NOT NULL")]
		public double PROFIT
		{
			get
			{
				return this._PROFIT;
			}
			set
			{
				if ((this._PROFIT != value))
				{
					this.OnPROFITChanging(value);
					this.SendPropertyChanging();
					this._PROFIT = value;
					this.SendPropertyChanged("PROFIT");
					this.OnPROFITChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CASHIER_SELL_ITEM", Storage="_CASHIER", ThisKey="CASHIER_ID", OtherKey="CASHIER_ID", IsForeignKey=true)]
		public CASHIER CASHIER
		{
			get
			{
				return this._CASHIER.Entity;
			}
			set
			{
				CASHIER previousValue = this._CASHIER.Entity;
				if (((previousValue != value) 
							|| (this._CASHIER.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CASHIER.Entity = null;
						previousValue.SELL_ITEMs.Remove(this);
					}
					this._CASHIER.Entity = value;
					if ((value != null))
					{
						value.SELL_ITEMs.Add(this);
						this._CASHIER_ID = value.CASHIER_ID;
					}
					else
					{
						this._CASHIER_ID = default(int);
					}
					this.SendPropertyChanged("CASHIER");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PRODUCT")]
	public partial class PRODUCT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PRODUCT_ID;
		
		private string _NAME;
		
		private double _PURCHASE_PRICE;
		
		private double _SELLING_PRICE;
		
		private int _ADMIN_ID;
		
		private int _SUPPLIER_ID;
		
		private string _DATE;
		
		private double _QUANTITY;
		
		private EntityRef<ADMIN> _ADMIN;
		
		private EntityRef<SUPPLIER> _SUPPLIER;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPRODUCT_IDChanging(int value);
    partial void OnPRODUCT_IDChanged();
    partial void OnNAMEChanging(string value);
    partial void OnNAMEChanged();
    partial void OnPURCHASE_PRICEChanging(double value);
    partial void OnPURCHASE_PRICEChanged();
    partial void OnSELLING_PRICEChanging(double value);
    partial void OnSELLING_PRICEChanged();
    partial void OnADMIN_IDChanging(int value);
    partial void OnADMIN_IDChanged();
    partial void OnSUPPLIER_IDChanging(int value);
    partial void OnSUPPLIER_IDChanged();
    partial void OnDATEChanging(string value);
    partial void OnDATEChanged();
    partial void OnQUANTITYChanging(double value);
    partial void OnQUANTITYChanged();
    #endregion
		
		public PRODUCT()
		{
			this._ADMIN = default(EntityRef<ADMIN>);
			this._SUPPLIER = default(EntityRef<SUPPLIER>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PRODUCT_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PRODUCT_ID
		{
			get
			{
				return this._PRODUCT_ID;
			}
			set
			{
				if ((this._PRODUCT_ID != value))
				{
					this.OnPRODUCT_IDChanging(value);
					this.SendPropertyChanging();
					this._PRODUCT_ID = value;
					this.SendPropertyChanged("PRODUCT_ID");
					this.OnPRODUCT_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NAME
		{
			get
			{
				return this._NAME;
			}
			set
			{
				if ((this._NAME != value))
				{
					this.OnNAMEChanging(value);
					this.SendPropertyChanging();
					this._NAME = value;
					this.SendPropertyChanged("NAME");
					this.OnNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PURCHASE_PRICE", DbType="Float NOT NULL")]
		public double PURCHASE_PRICE
		{
			get
			{
				return this._PURCHASE_PRICE;
			}
			set
			{
				if ((this._PURCHASE_PRICE != value))
				{
					this.OnPURCHASE_PRICEChanging(value);
					this.SendPropertyChanging();
					this._PURCHASE_PRICE = value;
					this.SendPropertyChanged("PURCHASE_PRICE");
					this.OnPURCHASE_PRICEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SELLING_PRICE", DbType="Float NOT NULL")]
		public double SELLING_PRICE
		{
			get
			{
				return this._SELLING_PRICE;
			}
			set
			{
				if ((this._SELLING_PRICE != value))
				{
					this.OnSELLING_PRICEChanging(value);
					this.SendPropertyChanging();
					this._SELLING_PRICE = value;
					this.SendPropertyChanged("SELLING_PRICE");
					this.OnSELLING_PRICEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ADMIN_ID", DbType="Int NOT NULL")]
		public int ADMIN_ID
		{
			get
			{
				return this._ADMIN_ID;
			}
			set
			{
				if ((this._ADMIN_ID != value))
				{
					if (this._ADMIN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnADMIN_IDChanging(value);
					this.SendPropertyChanging();
					this._ADMIN_ID = value;
					this.SendPropertyChanged("ADMIN_ID");
					this.OnADMIN_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SUPPLIER_ID", DbType="Int NOT NULL")]
		public int SUPPLIER_ID
		{
			get
			{
				return this._SUPPLIER_ID;
			}
			set
			{
				if ((this._SUPPLIER_ID != value))
				{
					if (this._SUPPLIER.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSUPPLIER_IDChanging(value);
					this.SendPropertyChanging();
					this._SUPPLIER_ID = value;
					this.SendPropertyChanged("SUPPLIER_ID");
					this.OnSUPPLIER_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATE", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DATE
		{
			get
			{
				return this._DATE;
			}
			set
			{
				if ((this._DATE != value))
				{
					this.OnDATEChanging(value);
					this.SendPropertyChanging();
					this._DATE = value;
					this.SendPropertyChanged("DATE");
					this.OnDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QUANTITY", DbType="Float NOT NULL")]
		public double QUANTITY
		{
			get
			{
				return this._QUANTITY;
			}
			set
			{
				if ((this._QUANTITY != value))
				{
					this.OnQUANTITYChanging(value);
					this.SendPropertyChanging();
					this._QUANTITY = value;
					this.SendPropertyChanged("QUANTITY");
					this.OnQUANTITYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ADMIN_PRODUCT", Storage="_ADMIN", ThisKey="ADMIN_ID", OtherKey="ADMIN_ID", IsForeignKey=true)]
		public ADMIN ADMIN
		{
			get
			{
				return this._ADMIN.Entity;
			}
			set
			{
				ADMIN previousValue = this._ADMIN.Entity;
				if (((previousValue != value) 
							|| (this._ADMIN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ADMIN.Entity = null;
						previousValue.PRODUCTs.Remove(this);
					}
					this._ADMIN.Entity = value;
					if ((value != null))
					{
						value.PRODUCTs.Add(this);
						this._ADMIN_ID = value.ADMIN_ID;
					}
					else
					{
						this._ADMIN_ID = default(int);
					}
					this.SendPropertyChanged("ADMIN");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SUPPLIER_PRODUCT", Storage="_SUPPLIER", ThisKey="SUPPLIER_ID", OtherKey="SUPPLIER_ID", IsForeignKey=true)]
		public SUPPLIER SUPPLIER
		{
			get
			{
				return this._SUPPLIER.Entity;
			}
			set
			{
				SUPPLIER previousValue = this._SUPPLIER.Entity;
				if (((previousValue != value) 
							|| (this._SUPPLIER.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SUPPLIER.Entity = null;
						previousValue.PRODUCTs.Remove(this);
					}
					this._SUPPLIER.Entity = value;
					if ((value != null))
					{
						value.PRODUCTs.Add(this);
						this._SUPPLIER_ID = value.SUPPLIER_ID;
					}
					else
					{
						this._SUPPLIER_ID = default(int);
					}
					this.SendPropertyChanged("SUPPLIER");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SUPPLIER")]
	public partial class SUPPLIER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SUPPLIER_ID;
		
		private string _NAME;
		
		private string _TYPE;
		
		private EntitySet<PRODUCT> _PRODUCTs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSUPPLIER_IDChanging(int value);
    partial void OnSUPPLIER_IDChanged();
    partial void OnNAMEChanging(string value);
    partial void OnNAMEChanged();
    partial void OnTYPEChanging(string value);
    partial void OnTYPEChanged();
    #endregion
		
		public SUPPLIER()
		{
			this._PRODUCTs = new EntitySet<PRODUCT>(new Action<PRODUCT>(this.attach_PRODUCTs), new Action<PRODUCT>(this.detach_PRODUCTs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SUPPLIER_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SUPPLIER_ID
		{
			get
			{
				return this._SUPPLIER_ID;
			}
			set
			{
				if ((this._SUPPLIER_ID != value))
				{
					this.OnSUPPLIER_IDChanging(value);
					this.SendPropertyChanging();
					this._SUPPLIER_ID = value;
					this.SendPropertyChanged("SUPPLIER_ID");
					this.OnSUPPLIER_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NAME
		{
			get
			{
				return this._NAME;
			}
			set
			{
				if ((this._NAME != value))
				{
					this.OnNAMEChanging(value);
					this.SendPropertyChanging();
					this._NAME = value;
					this.SendPropertyChanged("NAME");
					this.OnNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TYPE", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TYPE
		{
			get
			{
				return this._TYPE;
			}
			set
			{
				if ((this._TYPE != value))
				{
					this.OnTYPEChanging(value);
					this.SendPropertyChanging();
					this._TYPE = value;
					this.SendPropertyChanged("TYPE");
					this.OnTYPEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SUPPLIER_PRODUCT", Storage="_PRODUCTs", ThisKey="SUPPLIER_ID", OtherKey="SUPPLIER_ID")]
		public EntitySet<PRODUCT> PRODUCTs
		{
			get
			{
				return this._PRODUCTs;
			}
			set
			{
				this._PRODUCTs.Assign(value);
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
		
		private void attach_PRODUCTs(PRODUCT entity)
		{
			this.SendPropertyChanging();
			entity.SUPPLIER = this;
		}
		
		private void detach_PRODUCTs(PRODUCT entity)
		{
			this.SendPropertyChanging();
			entity.SUPPLIER = null;
		}
	}
}
#pragma warning restore 1591
