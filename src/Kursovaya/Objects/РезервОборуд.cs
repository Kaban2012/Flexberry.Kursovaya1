﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Kursovaya
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Резерв оборуд.
    /// </summary>
    // *** Start programmer edit section *** (РезервОборуд CustomAttributes)

    // *** End programmer edit section *** (РезервОборуд CustomAttributes)
    [AutoAltered()]
    [Caption("Резерв оборуд")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("РезервОборудE", new string[] {
            "ДатаПоступления as \'Дата поступления\'",
            "ДатаУстановки as \'Дата установки\'",
            "СерийныйНомер as \'Серийный номер\'",
            "Состояние as \'Состояние\'",
            "Модель as \'Модель\'",
            "Модель.Название as \'Название\'",
            "Администратор as \'Администратор\'",
            "Администратор.ФИО as \'ФИО\'",
            "Тип as \'Тип\'",
            "Тип.Название as \'Название\'"}, Hidden=new string[] {
            "Модель.Название",
            "Администратор.ФИО",
            "Тип.Название"})]
    [MasterViewDefineAttribute("РезервОборудE", "Модель", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    [MasterViewDefineAttribute("РезервОборудE", "Администратор", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ФИО")]
    [MasterViewDefineAttribute("РезервОборудE", "Тип", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    public class РезервОборуд : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДатаПоступления;
        
        private System.DateTime fДатаУстановки;
        
        private string fСерийныйНомер;
        
        private IIS.Kursovaya.tСостояние fСостояние;
        
        private IIS.Kursovaya.Модель fМодель;
        
        private IIS.Kursovaya.Пользователь fАдминистратор;
        
        private IIS.Kursovaya.Тип fТип;
        
        private IIS.Kursovaya.Филиал fФилиал;
        
        // *** Start programmer edit section *** (РезервОборуд CustomMembers)

        // *** End programmer edit section *** (РезервОборуд CustomMembers)

        
        /// <summary>
        /// ДатаПоступления.
        /// </summary>
        // *** Start programmer edit section *** (РезервОборуд.ДатаПоступления CustomAttributes)

        // *** End programmer edit section *** (РезервОборуд.ДатаПоступления CustomAttributes)
        public virtual System.DateTime ДатаПоступления
        {
            get
            {
                // *** Start programmer edit section *** (РезервОборуд.ДатаПоступления Get start)

                // *** End programmer edit section *** (РезервОборуд.ДатаПоступления Get start)
                System.DateTime result = this.fДатаПоступления;
                // *** Start programmer edit section *** (РезервОборуд.ДатаПоступления Get end)

                // *** End programmer edit section *** (РезервОборуд.ДатаПоступления Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РезервОборуд.ДатаПоступления Set start)

                // *** End programmer edit section *** (РезервОборуд.ДатаПоступления Set start)
                this.fДатаПоступления = value;
                // *** Start programmer edit section *** (РезервОборуд.ДатаПоступления Set end)

                // *** End programmer edit section *** (РезервОборуд.ДатаПоступления Set end)
            }
        }
        
        /// <summary>
        /// ДатаУстановки.
        /// </summary>
        // *** Start programmer edit section *** (РезервОборуд.ДатаУстановки CustomAttributes)

        // *** End programmer edit section *** (РезервОборуд.ДатаУстановки CustomAttributes)
        public virtual System.DateTime ДатаУстановки
        {
            get
            {
                // *** Start programmer edit section *** (РезервОборуд.ДатаУстановки Get start)

                // *** End programmer edit section *** (РезервОборуд.ДатаУстановки Get start)
                System.DateTime result = this.fДатаУстановки;
                // *** Start programmer edit section *** (РезервОборуд.ДатаУстановки Get end)

                // *** End programmer edit section *** (РезервОборуд.ДатаУстановки Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РезервОборуд.ДатаУстановки Set start)

                // *** End programmer edit section *** (РезервОборуд.ДатаУстановки Set start)
                this.fДатаУстановки = value;
                // *** Start programmer edit section *** (РезервОборуд.ДатаУстановки Set end)

                // *** End programmer edit section *** (РезервОборуд.ДатаУстановки Set end)
            }
        }
        
        /// <summary>
        /// СерийныйНомер.
        /// </summary>
        // *** Start programmer edit section *** (РезервОборуд.СерийныйНомер CustomAttributes)

        // *** End programmer edit section *** (РезервОборуд.СерийныйНомер CustomAttributes)
        [StrLen(255)]
        public virtual string СерийныйНомер
        {
            get
            {
                // *** Start programmer edit section *** (РезервОборуд.СерийныйНомер Get start)

                // *** End programmer edit section *** (РезервОборуд.СерийныйНомер Get start)
                string result = this.fСерийныйНомер;
                // *** Start programmer edit section *** (РезервОборуд.СерийныйНомер Get end)

                // *** End programmer edit section *** (РезервОборуд.СерийныйНомер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РезервОборуд.СерийныйНомер Set start)

                // *** End programmer edit section *** (РезервОборуд.СерийныйНомер Set start)
                this.fСерийныйНомер = value;
                // *** Start programmer edit section *** (РезервОборуд.СерийныйНомер Set end)

                // *** End programmer edit section *** (РезервОборуд.СерийныйНомер Set end)
            }
        }
        
        /// <summary>
        /// Состояние.
        /// </summary>
        // *** Start programmer edit section *** (РезервОборуд.Состояние CustomAttributes)

        // *** End programmer edit section *** (РезервОборуд.Состояние CustomAttributes)
        public virtual IIS.Kursovaya.tСостояние Состояние
        {
            get
            {
                // *** Start programmer edit section *** (РезервОборуд.Состояние Get start)

                // *** End programmer edit section *** (РезервОборуд.Состояние Get start)
                IIS.Kursovaya.tСостояние result = this.fСостояние;
                // *** Start programmer edit section *** (РезервОборуд.Состояние Get end)

                // *** End programmer edit section *** (РезервОборуд.Состояние Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РезервОборуд.Состояние Set start)

                // *** End programmer edit section *** (РезервОборуд.Состояние Set start)
                this.fСостояние = value;
                // *** Start programmer edit section *** (РезервОборуд.Состояние Set end)

                // *** End programmer edit section *** (РезервОборуд.Состояние Set end)
            }
        }
        
        /// <summary>
        /// Резерв оборуд.
        /// </summary>
        // *** Start programmer edit section *** (РезервОборуд.Администратор CustomAttributes)

        // *** End programmer edit section *** (РезервОборуд.Администратор CustomAttributes)
        [PropertyStorage(new string[] {
                "Администратор"})]
        [NotNull()]
        public virtual IIS.Kursovaya.Пользователь Администратор
        {
            get
            {
                // *** Start programmer edit section *** (РезервОборуд.Администратор Get start)

                // *** End programmer edit section *** (РезервОборуд.Администратор Get start)
                IIS.Kursovaya.Пользователь result = this.fАдминистратор;
                // *** Start programmer edit section *** (РезервОборуд.Администратор Get end)

                // *** End programmer edit section *** (РезервОборуд.Администратор Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РезервОборуд.Администратор Set start)

                // *** End programmer edit section *** (РезервОборуд.Администратор Set start)
                this.fАдминистратор = value;
                // *** Start programmer edit section *** (РезервОборуд.Администратор Set end)

                // *** End programmer edit section *** (РезервОборуд.Администратор Set end)
            }
        }
        
        /// <summary>
        /// Резерв оборуд.
        /// </summary>
        // *** Start programmer edit section *** (РезервОборуд.Модель CustomAttributes)

        // *** End programmer edit section *** (РезервОборуд.Модель CustomAttributes)
        [PropertyStorage(new string[] {
                "Модель"})]
        [NotNull()]
        public virtual IIS.Kursovaya.Модель Модель
        {
            get
            {
                // *** Start programmer edit section *** (РезервОборуд.Модель Get start)

                // *** End programmer edit section *** (РезервОборуд.Модель Get start)
                IIS.Kursovaya.Модель result = this.fМодель;
                // *** Start programmer edit section *** (РезервОборуд.Модель Get end)

                // *** End programmer edit section *** (РезервОборуд.Модель Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РезервОборуд.Модель Set start)

                // *** End programmer edit section *** (РезервОборуд.Модель Set start)
                this.fМодель = value;
                // *** Start programmer edit section *** (РезервОборуд.Модель Set end)

                // *** End programmer edit section *** (РезервОборуд.Модель Set end)
            }
        }
        
        /// <summary>
        /// Резерв оборуд.
        /// </summary>
        // *** Start programmer edit section *** (РезервОборуд.Тип CustomAttributes)

        // *** End programmer edit section *** (РезервОборуд.Тип CustomAttributes)
        [PropertyStorage(new string[] {
                "Тип"})]
        [NotNull()]
        public virtual IIS.Kursovaya.Тип Тип
        {
            get
            {
                // *** Start programmer edit section *** (РезервОборуд.Тип Get start)

                // *** End programmer edit section *** (РезервОборуд.Тип Get start)
                IIS.Kursovaya.Тип result = this.fТип;
                // *** Start programmer edit section *** (РезервОборуд.Тип Get end)

                // *** End programmer edit section *** (РезервОборуд.Тип Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РезервОборуд.Тип Set start)

                // *** End programmer edit section *** (РезервОборуд.Тип Set start)
                this.fТип = value;
                // *** Start programmer edit section *** (РезервОборуд.Тип Set end)

                // *** End programmer edit section *** (РезервОборуд.Тип Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Kursovaya.Филиал.
        /// </summary>
        // *** Start programmer edit section *** (РезервОборуд.Филиал CustomAttributes)

        // *** End programmer edit section *** (РезервОборуд.Филиал CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Филиал"})]
        public virtual IIS.Kursovaya.Филиал Филиал
        {
            get
            {
                // *** Start programmer edit section *** (РезервОборуд.Филиал Get start)

                // *** End programmer edit section *** (РезервОборуд.Филиал Get start)
                IIS.Kursovaya.Филиал result = this.fФилиал;
                // *** Start programmer edit section *** (РезервОборуд.Филиал Get end)

                // *** End programmer edit section *** (РезервОборуд.Филиал Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РезервОборуд.Филиал Set start)

                // *** End programmer edit section *** (РезервОборуд.Филиал Set start)
                this.fФилиал = value;
                // *** Start programmer edit section *** (РезервОборуд.Филиал Set end)

                // *** End programmer edit section *** (РезервОборуд.Филиал Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "РезервОборудE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View РезервОборудE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("РезервОборудE", typeof(IIS.Kursovaya.РезервОборуд));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of РезервОборуд.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfРезервОборуд CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfРезервОборуд CustomAttributes)
    public class DetailArrayOfРезервОборуд : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Kursovaya.DetailArrayOfРезервОборуд members)

        // *** End programmer edit section *** (IIS.Kursovaya.DetailArrayOfРезервОборуд members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type РезервОборуд by index.
        /// </summary>
        /// <summary>
        /// Adds object with type РезервОборуд.
        /// </summary>
        public DetailArrayOfРезервОборуд(IIS.Kursovaya.Филиал fФилиал) : 
                base(typeof(РезервОборуд), ((ICSSoft.STORMNET.DataObject)(fФилиал)))
        {
        }
        
        public IIS.Kursovaya.РезервОборуд this[int index]
        {
            get
            {
                return ((IIS.Kursovaya.РезервОборуд)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Kursovaya.РезервОборуд dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
