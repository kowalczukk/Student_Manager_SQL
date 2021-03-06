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

namespace StudentManager2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Students2")]
	public partial class StudentsDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    partial void InsertSubject(Subject instance);
    partial void UpdateSubject(Subject instance);
    partial void DeleteSubject(Subject instance);
    partial void InsertMark(Mark instance);
    partial void UpdateMark(Mark instance);
    partial void DeleteMark(Mark instance);
    partial void InsertTeacher(Teacher instance);
    partial void UpdateTeacher(Teacher instance);
    partial void DeleteTeacher(Teacher instance);
    #endregion
		
		public StudentsDataDataContext() : 
				base(global::StudentManager2.Properties.Settings.Default.Students2ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StudentsDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentsDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentsDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentsDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
		
		public System.Data.Linq.Table<Subject> Subjects
		{
			get
			{
				return this.GetTable<Subject>();
			}
		}
		
		public System.Data.Linq.Table<Mark> Marks
		{
			get
			{
				return this.GetTable<Mark>();
			}
		}
		
		public System.Data.Linq.Table<Teacher> Teachers
		{
			get
			{
				return this.GetTable<Teacher>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Students")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private EntitySet<Mark> _Marks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    #endregion
		
		public Student()
		{
			this._Marks = new EntitySet<Mark>(new Action<Mark>(this.attach_Marks), new Action<Mark>(this.detach_Marks));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Mark", Storage="_Marks", ThisKey="ID", OtherKey="studentID")]
		public EntitySet<Mark> Marks
		{
			get
			{
				return this._Marks;
			}
			set
			{
				this._Marks.Assign(value);
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
		
		private void attach_Marks(Mark entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_Marks(Mark entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Subjects")]
	public partial class Subject : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _SubjectName;
		
		private EntitySet<Mark> _Marks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnSubjectNameChanging(string value);
    partial void OnSubjectNameChanged();
    #endregion
		
		public Subject()
		{
			this._Marks = new EntitySet<Mark>(new Action<Mark>(this.attach_Marks), new Action<Mark>(this.detach_Marks));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectName", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string SubjectName
		{
			get
			{
				return this._SubjectName;
			}
			set
			{
				if ((this._SubjectName != value))
				{
					this.OnSubjectNameChanging(value);
					this.SendPropertyChanging();
					this._SubjectName = value;
					this.SendPropertyChanged("SubjectName");
					this.OnSubjectNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subject_Mark", Storage="_Marks", ThisKey="ID", OtherKey="subjectID")]
		public EntitySet<Mark> Marks
		{
			get
			{
				return this._Marks;
			}
			set
			{
				this._Marks.Assign(value);
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
		
		private void attach_Marks(Mark entity)
		{
			this.SendPropertyChanging();
			entity.Subject = this;
		}
		
		private void detach_Marks(Mark entity)
		{
			this.SendPropertyChanging();
			entity.Subject = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Marks")]
	public partial class Mark : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _subjectID;
		
		private int _studentID;
		
		private int _TeacherID;
		
		private int _number;
		
		private string _type;
		
		private EntityRef<Student> _Student;
		
		private EntityRef<Subject> _Subject;
		
		private EntityRef<Teacher> _Teacher;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnsubjectIDChanging(int value);
    partial void OnsubjectIDChanged();
    partial void OnstudentIDChanging(int value);
    partial void OnstudentIDChanged();
    partial void OnTeacherIDChanging(int value);
    partial void OnTeacherIDChanged();
    partial void OnnumberChanging(int value);
    partial void OnnumberChanged();
    partial void OntypeChanging(string value);
    partial void OntypeChanged();
    #endregion
		
		public Mark()
		{
			this._Student = default(EntityRef<Student>);
			this._Subject = default(EntityRef<Subject>);
			this._Teacher = default(EntityRef<Teacher>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subjectID", DbType="Int NOT NULL")]
		public int subjectID
		{
			get
			{
				return this._subjectID;
			}
			set
			{
				if ((this._subjectID != value))
				{
					if (this._Subject.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsubjectIDChanging(value);
					this.SendPropertyChanging();
					this._subjectID = value;
					this.SendPropertyChanged("subjectID");
					this.OnsubjectIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentID", DbType="Int NOT NULL")]
		public int studentID
		{
			get
			{
				return this._studentID;
			}
			set
			{
				if ((this._studentID != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnstudentIDChanging(value);
					this.SendPropertyChanging();
					this._studentID = value;
					this.SendPropertyChanged("studentID");
					this.OnstudentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeacherID", DbType="Int NOT NULL")]
		public int TeacherID
		{
			get
			{
				return this._TeacherID;
			}
			set
			{
				if ((this._TeacherID != value))
				{
					if (this._Teacher.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTeacherIDChanging(value);
					this.SendPropertyChanging();
					this._TeacherID = value;
					this.SendPropertyChanged("TeacherID");
					this.OnTeacherIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_number", DbType="Int NOT NULL")]
		public int number
		{
			get
			{
				return this._number;
			}
			set
			{
				if ((this._number != value))
				{
					this.OnnumberChanging(value);
					this.SendPropertyChanging();
					this._number = value;
					this.SendPropertyChanged("number");
					this.OnnumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="VarChar(200)")]
		public string type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Mark", Storage="_Student", ThisKey="studentID", OtherKey="ID", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.Marks.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.Marks.Add(this);
						this._studentID = value.ID;
					}
					else
					{
						this._studentID = default(int);
					}
					this.SendPropertyChanged("Student");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subject_Mark", Storage="_Subject", ThisKey="subjectID", OtherKey="ID", IsForeignKey=true)]
		public Subject Subject
		{
			get
			{
				return this._Subject.Entity;
			}
			set
			{
				Subject previousValue = this._Subject.Entity;
				if (((previousValue != value) 
							|| (this._Subject.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Subject.Entity = null;
						previousValue.Marks.Remove(this);
					}
					this._Subject.Entity = value;
					if ((value != null))
					{
						value.Marks.Add(this);
						this._subjectID = value.ID;
					}
					else
					{
						this._subjectID = default(int);
					}
					this.SendPropertyChanged("Subject");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teacher_Mark", Storage="_Teacher", ThisKey="TeacherID", OtherKey="ID", IsForeignKey=true)]
		public Teacher Teacher
		{
			get
			{
				return this._Teacher.Entity;
			}
			set
			{
				Teacher previousValue = this._Teacher.Entity;
				if (((previousValue != value) 
							|| (this._Teacher.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Teacher.Entity = null;
						previousValue.Marks.Remove(this);
					}
					this._Teacher.Entity = value;
					if ((value != null))
					{
						value.Marks.Add(this);
						this._TeacherID = value.ID;
					}
					else
					{
						this._TeacherID = default(int);
					}
					this.SendPropertyChanged("Teacher");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Teachers")]
	public partial class Teacher : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private EntitySet<Mark> _Marks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    #endregion
		
		public Teacher()
		{
			this._Marks = new EntitySet<Mark>(new Action<Mark>(this.attach_Marks), new Action<Mark>(this.detach_Marks));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teacher_Mark", Storage="_Marks", ThisKey="ID", OtherKey="TeacherID")]
		public EntitySet<Mark> Marks
		{
			get
			{
				return this._Marks;
			}
			set
			{
				this._Marks.Assign(value);
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
		
		private void attach_Marks(Mark entity)
		{
			this.SendPropertyChanging();
			entity.Teacher = this;
		}
		
		private void detach_Marks(Mark entity)
		{
			this.SendPropertyChanging();
			entity.Teacher = null;
		}
	}
}
#pragma warning restore 1591
