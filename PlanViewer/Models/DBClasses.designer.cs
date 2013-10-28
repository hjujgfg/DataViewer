﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanViewer.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TeamProjectDB2")]
	public partial class DBClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertContractor(Contractor instance);
    partial void UpdateContractor(Contractor instance);
    partial void DeleteContractor(Contractor instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertFact(Fact instance);
    partial void UpdateFact(Fact instance);
    partial void DeleteFact(Fact instance);
    partial void InsertPlan(Plan instance);
    partial void UpdatePlan(Plan instance);
    partial void DeletePlan(Plan instance);
    #endregion
		
		public DBClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TeamProjectDB2ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Contractor> Contractors
		{
			get
			{
				return this.GetTable<Contractor>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Fact> Facts
		{
			get
			{
				return this.GetTable<Fact>();
			}
		}
		
		public System.Data.Linq.Table<Plan> Plans
		{
			get
			{
				return this.GetTable<Plan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Contractor")]
	public partial class Contractor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Email;
		
		private string _Address;
		
		private string _Info;
		
		private EntitySet<Plan> _Plans;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnInfoChanging(string value);
    partial void OnInfoChanged();
    #endregion
		
		public Contractor()
		{
			this._Plans = new EntitySet<Plan>(new Action<Plan>(this.attach_Plans), new Action<Plan>(this.detach_Plans));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Info", DbType="NVarChar(50)")]
		public string Info
		{
			get
			{
				return this._Info;
			}
			set
			{
				if ((this._Info != value))
				{
					this.OnInfoChanging(value);
					this.SendPropertyChanging();
					this._Info = value;
					this.SendPropertyChanged("Info");
					this.OnInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Contractor_Plan", Storage="_Plans", ThisKey="ID", OtherKey="Contractor")]
		public EntitySet<Plan> Plans
		{
			get
			{
				return this._Plans;
			}
			set
			{
				this._Plans.Assign(value);
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
		
		private void attach_Plans(Plan entity)
		{
			this.SendPropertyChanging();
			entity.Contractor1 = this;
		}
		
		private void detach_Plans(Plan entity)
		{
			this.SendPropertyChanging();
			entity.Contractor1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Email;
		
		private string _Address;
		
		private string _Info;
		
		private EntitySet<Plan> _Plans;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnInfoChanging(string value);
    partial void OnInfoChanged();
    #endregion
		
		public Customer()
		{
			this._Plans = new EntitySet<Plan>(new Action<Plan>(this.attach_Plans), new Action<Plan>(this.detach_Plans));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Info", DbType="NVarChar(50)")]
		public string Info
		{
			get
			{
				return this._Info;
			}
			set
			{
				if ((this._Info != value))
				{
					this.OnInfoChanging(value);
					this.SendPropertyChanging();
					this._Info = value;
					this.SendPropertyChanged("Info");
					this.OnInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Plan", Storage="_Plans", ThisKey="ID", OtherKey="Customer")]
		public EntitySet<Plan> Plans
		{
			get
			{
				return this._Plans;
			}
			set
			{
				this._Plans.Assign(value);
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
		
		private void attach_Plans(Plan entity)
		{
			this.SendPropertyChanging();
			entity.Customer1 = this;
		}
		
		private void detach_Plans(Plan entity)
		{
			this.SendPropertyChanging();
			entity.Customer1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Fact")]
	public partial class Fact : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _FactObject;
		
		private string _WorkType;
		
		private string _UnitName;
		
		private string _CostName;
		
		private string _Labor;
		
		private string _Materials;
		
		private string _Mechanisms;
		
		private EntitySet<Plan> _Plans;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFactObjectChanging(string value);
    partial void OnFactObjectChanged();
    partial void OnWorkTypeChanging(string value);
    partial void OnWorkTypeChanged();
    partial void OnUnitNameChanging(string value);
    partial void OnUnitNameChanged();
    partial void OnCostNameChanging(string value);
    partial void OnCostNameChanged();
    partial void OnLaborChanging(string value);
    partial void OnLaborChanged();
    partial void OnMaterialsChanging(string value);
    partial void OnMaterialsChanged();
    partial void OnMechanismsChanging(string value);
    partial void OnMechanismsChanged();
    #endregion
		
		public Fact()
		{
			this._Plans = new EntitySet<Plan>(new Action<Plan>(this.attach_Plans), new Action<Plan>(this.detach_Plans));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FactObject", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FactObject
		{
			get
			{
				return this._FactObject;
			}
			set
			{
				if ((this._FactObject != value))
				{
					this.OnFactObjectChanging(value);
					this.SendPropertyChanging();
					this._FactObject = value;
					this.SendPropertyChanged("FactObject");
					this.OnFactObjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkType", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string WorkType
		{
			get
			{
				return this._WorkType;
			}
			set
			{
				if ((this._WorkType != value))
				{
					this.OnWorkTypeChanging(value);
					this.SendPropertyChanging();
					this._WorkType = value;
					this.SendPropertyChanged("WorkType");
					this.OnWorkTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UnitName
		{
			get
			{
				return this._UnitName;
			}
			set
			{
				if ((this._UnitName != value))
				{
					this.OnUnitNameChanging(value);
					this.SendPropertyChanging();
					this._UnitName = value;
					this.SendPropertyChanged("UnitName");
					this.OnUnitNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CostName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CostName
		{
			get
			{
				return this._CostName;
			}
			set
			{
				if ((this._CostName != value))
				{
					this.OnCostNameChanging(value);
					this.SendPropertyChanging();
					this._CostName = value;
					this.SendPropertyChanged("CostName");
					this.OnCostNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Labor", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Labor
		{
			get
			{
				return this._Labor;
			}
			set
			{
				if ((this._Labor != value))
				{
					this.OnLaborChanging(value);
					this.SendPropertyChanging();
					this._Labor = value;
					this.SendPropertyChanged("Labor");
					this.OnLaborChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Materials", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Materials
		{
			get
			{
				return this._Materials;
			}
			set
			{
				if ((this._Materials != value))
				{
					this.OnMaterialsChanging(value);
					this.SendPropertyChanging();
					this._Materials = value;
					this.SendPropertyChanged("Materials");
					this.OnMaterialsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mechanisms", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Mechanisms
		{
			get
			{
				return this._Mechanisms;
			}
			set
			{
				if ((this._Mechanisms != value))
				{
					this.OnMechanismsChanging(value);
					this.SendPropertyChanging();
					this._Mechanisms = value;
					this.SendPropertyChanged("Mechanisms");
					this.OnMechanismsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fact_Plan", Storage="_Plans", ThisKey="ID", OtherKey="Fact")]
		public EntitySet<Plan> Plans
		{
			get
			{
				return this._Plans;
			}
			set
			{
				this._Plans.Assign(value);
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
		
		private void attach_Plans(Plan entity)
		{
			this.SendPropertyChanging();
			entity.Fact1 = this;
		}
		
		private void detach_Plans(Plan entity)
		{
			this.SendPropertyChanging();
			entity.Fact1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Plan]")]
	public partial class Plan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Object;
		
		private string _WorkType;
		
		private string _UnitName;
		
		private string _CostName;
		
		private string _Labor;
		
		private string _Materials;
		
		private string _Mechnisms;
		
		private int _Customer;
		
		private int _Contractor;
		
		private System.Nullable<int> _Fact;
		
		private EntityRef<Contractor> _Contractor1;
		
		private EntityRef<Customer> _Customer1;
		
		private EntityRef<Fact> _Fact1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnObjectChanging(string value);
    partial void OnObjectChanged();
    partial void OnWorkTypeChanging(string value);
    partial void OnWorkTypeChanged();
    partial void OnUnitNameChanging(string value);
    partial void OnUnitNameChanged();
    partial void OnCostNameChanging(string value);
    partial void OnCostNameChanged();
    partial void OnLaborChanging(string value);
    partial void OnLaborChanged();
    partial void OnMaterialsChanging(string value);
    partial void OnMaterialsChanged();
    partial void OnMechnismsChanging(string value);
    partial void OnMechnismsChanged();
    partial void OnCustomerChanging(int value);
    partial void OnCustomerChanged();
    partial void OnContractorChanging(int value);
    partial void OnContractorChanged();
    partial void OnFactChanging(System.Nullable<int> value);
    partial void OnFactChanged();
    #endregion
		
		public Plan()
		{
			this._Contractor1 = default(EntityRef<Contractor>);
			this._Customer1 = default(EntityRef<Customer>);
			this._Fact1 = default(EntityRef<Fact>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Object", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Object
		{
			get
			{
				return this._Object;
			}
			set
			{
				if ((this._Object != value))
				{
					this.OnObjectChanging(value);
					this.SendPropertyChanging();
					this._Object = value;
					this.SendPropertyChanged("Object");
					this.OnObjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkType", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string WorkType
		{
			get
			{
				return this._WorkType;
			}
			set
			{
				if ((this._WorkType != value))
				{
					this.OnWorkTypeChanging(value);
					this.SendPropertyChanging();
					this._WorkType = value;
					this.SendPropertyChanged("WorkType");
					this.OnWorkTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UnitName
		{
			get
			{
				return this._UnitName;
			}
			set
			{
				if ((this._UnitName != value))
				{
					this.OnUnitNameChanging(value);
					this.SendPropertyChanging();
					this._UnitName = value;
					this.SendPropertyChanged("UnitName");
					this.OnUnitNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CostName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CostName
		{
			get
			{
				return this._CostName;
			}
			set
			{
				if ((this._CostName != value))
				{
					this.OnCostNameChanging(value);
					this.SendPropertyChanging();
					this._CostName = value;
					this.SendPropertyChanged("CostName");
					this.OnCostNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Labor", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Labor
		{
			get
			{
				return this._Labor;
			}
			set
			{
				if ((this._Labor != value))
				{
					this.OnLaborChanging(value);
					this.SendPropertyChanging();
					this._Labor = value;
					this.SendPropertyChanged("Labor");
					this.OnLaborChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Materials", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Materials
		{
			get
			{
				return this._Materials;
			}
			set
			{
				if ((this._Materials != value))
				{
					this.OnMaterialsChanging(value);
					this.SendPropertyChanging();
					this._Materials = value;
					this.SendPropertyChanged("Materials");
					this.OnMaterialsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mechnisms", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Mechnisms
		{
			get
			{
				return this._Mechnisms;
			}
			set
			{
				if ((this._Mechnisms != value))
				{
					this.OnMechnismsChanging(value);
					this.SendPropertyChanging();
					this._Mechnisms = value;
					this.SendPropertyChanged("Mechnisms");
					this.OnMechnismsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer", DbType="Int NOT NULL")]
		public int Customer
		{
			get
			{
				return this._Customer;
			}
			set
			{
				if ((this._Customer != value))
				{
					if (this._Customer1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerChanging(value);
					this.SendPropertyChanging();
					this._Customer = value;
					this.SendPropertyChanged("Customer");
					this.OnCustomerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contractor", DbType="Int NOT NULL")]
		public int Contractor
		{
			get
			{
				return this._Contractor;
			}
			set
			{
				if ((this._Contractor != value))
				{
					if (this._Contractor1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnContractorChanging(value);
					this.SendPropertyChanging();
					this._Contractor = value;
					this.SendPropertyChanged("Contractor");
					this.OnContractorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fact", DbType="Int")]
		public System.Nullable<int> Fact
		{
			get
			{
				return this._Fact;
			}
			set
			{
				if ((this._Fact != value))
				{
					if (this._Fact1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFactChanging(value);
					this.SendPropertyChanging();
					this._Fact = value;
					this.SendPropertyChanged("Fact");
					this.OnFactChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Contractor_Plan", Storage="_Contractor1", ThisKey="Contractor", OtherKey="ID", IsForeignKey=true)]
		public Contractor Contractor1
		{
			get
			{
				return this._Contractor1.Entity;
			}
			set
			{
				Contractor previousValue = this._Contractor1.Entity;
				if (((previousValue != value) 
							|| (this._Contractor1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Contractor1.Entity = null;
						previousValue.Plans.Remove(this);
					}
					this._Contractor1.Entity = value;
					if ((value != null))
					{
						value.Plans.Add(this);
						this._Contractor = value.ID;
					}
					else
					{
						this._Contractor = default(int);
					}
					this.SendPropertyChanged("Contractor1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Plan", Storage="_Customer1", ThisKey="Customer", OtherKey="ID", IsForeignKey=true)]
		public Customer Customer1
		{
			get
			{
				return this._Customer1.Entity;
			}
			set
			{
				Customer previousValue = this._Customer1.Entity;
				if (((previousValue != value) 
							|| (this._Customer1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer1.Entity = null;
						previousValue.Plans.Remove(this);
					}
					this._Customer1.Entity = value;
					if ((value != null))
					{
						value.Plans.Add(this);
						this._Customer = value.ID;
					}
					else
					{
						this._Customer = default(int);
					}
					this.SendPropertyChanged("Customer1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fact_Plan", Storage="_Fact1", ThisKey="Fact", OtherKey="ID", IsForeignKey=true)]
		public Fact Fact1
		{
			get
			{
				return this._Fact1.Entity;
			}
			set
			{
				Fact previousValue = this._Fact1.Entity;
				if (((previousValue != value) 
							|| (this._Fact1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Fact1.Entity = null;
						previousValue.Plans.Remove(this);
					}
					this._Fact1.Entity = value;
					if ((value != null))
					{
						value.Plans.Add(this);
						this._Fact = value.ID;
					}
					else
					{
						this._Fact = default(Nullable<int>);
					}
					this.SendPropertyChanged("Fact1");
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
}
#pragma warning restore 1591
