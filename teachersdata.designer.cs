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

namespace FinalWorkProject
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Managment")]
	public partial class teachersdataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTeacherData(TeacherData instance);
    partial void UpdateTeacherData(TeacherData instance);
    partial void DeleteTeacherData(TeacherData instance);
    #endregion
		
		public teachersdataDataContext() : 
				base(global::FinalWorkProject.Properties.Settings.Default.ManagmentConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public teachersdataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public teachersdataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public teachersdataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public teachersdataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TeacherData> TeacherDatas
		{
			get
			{
				return this.GetTable<TeacherData>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TeacherData")]
	public partial class TeacherData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _TeacherID;
		
		private string _First_Name;
		
		private string _Last_Name;
		
		private string _Surname;
		
		private System.Nullable<System.DateTime> _Date_of_Birth;
		
		private System.Nullable<System.DateTime> _JoiningDate;
		
		private string _Religion;
		
		private string _Gender;
		
		private int _Phone;
		
		private string _Email;
		
		private System.Data.Linq.Binary _TeacherPicture;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTeacherIDChanging(System.Guid value);
    partial void OnTeacherIDChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnDate_of_BirthChanging(System.Nullable<System.DateTime> value);
    partial void OnDate_of_BirthChanged();
    partial void OnJoiningDateChanging(System.Nullable<System.DateTime> value);
    partial void OnJoiningDateChanged();
    partial void OnReligionChanging(string value);
    partial void OnReligionChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnPhoneChanging(int value);
    partial void OnPhoneChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnTeacherPictureChanging(System.Data.Linq.Binary value);
    partial void OnTeacherPictureChanged();
    #endregion
		
		public TeacherData()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeacherID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid TeacherID
		{
			get
			{
				return this._TeacherID;
			}
			set
			{
				if ((this._TeacherID != value))
				{
					this.OnTeacherIDChanging(value);
					this.SendPropertyChanging();
					this._TeacherID = value;
					this.SendPropertyChanged("TeacherID");
					this.OnTeacherIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[First Name]", Storage="_First_Name", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Last Name]", Storage="_Last_Name", DbType="NChar(30)")]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Date of Birth]", Storage="_Date_of_Birth", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> Date_of_Birth
		{
			get
			{
				return this._Date_of_Birth;
			}
			set
			{
				if ((this._Date_of_Birth != value))
				{
					this.OnDate_of_BirthChanging(value);
					this.SendPropertyChanging();
					this._Date_of_Birth = value;
					this.SendPropertyChanged("Date_of_Birth");
					this.OnDate_of_BirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JoiningDate", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> JoiningDate
		{
			get
			{
				return this._JoiningDate;
			}
			set
			{
				if ((this._JoiningDate != value))
				{
					this.OnJoiningDateChanging(value);
					this.SendPropertyChanging();
					this._JoiningDate = value;
					this.SendPropertyChanged("JoiningDate");
					this.OnJoiningDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Religion", DbType="NChar(20)")]
		public string Religion
		{
			get
			{
				return this._Religion;
			}
			set
			{
				if ((this._Religion != value))
				{
					this.OnReligionChanging(value);
					this.SendPropertyChanging();
					this._Religion = value;
					this.SendPropertyChanged("Religion");
					this.OnReligionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NChar(10)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="Int NOT NULL")]
		public int Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeacherPicture", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary TeacherPicture
		{
			get
			{
				return this._TeacherPicture;
			}
			set
			{
				if ((this._TeacherPicture != value))
				{
					this.OnTeacherPictureChanging(value);
					this.SendPropertyChanging();
					this._TeacherPicture = value;
					this.SendPropertyChanged("TeacherPicture");
					this.OnTeacherPictureChanged();
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