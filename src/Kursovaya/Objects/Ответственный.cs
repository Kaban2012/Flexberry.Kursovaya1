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
    /// Ответственный.
    /// </summary>
    // *** Start programmer edit section *** (Ответственный CustomAttributes)

    // *** End programmer edit section *** (Ответственный CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ОтветственныйE", new string[] {
            "ФИО as \'ФИО\'",
            "НомерТелефона as \'Номер телефона\'",
            "РабочаяПочта as \'Рабочая почта\'"})]
    [View("ОтветственныйL", new string[] {
            "ФИО as \'ФИО\'",
            "НомерТелефона as \'Номер телефона\'",
            "РабочаяПочта as \'Рабочая почта\'"})]
    public class Ответственный : ICSSoft.STORMNET.DataObject
    {
        
        private string fФИО;
        
        private int fНомерТелефона;
        
        private string fРабочаяПочта;
        
        // *** Start programmer edit section *** (Ответственный CustomMembers)

        // *** End programmer edit section *** (Ответственный CustomMembers)

        
        /// <summary>
        /// НомерТелефона.
        /// </summary>
        // *** Start programmer edit section *** (Ответственный.НомерТелефона CustomAttributes)

        // *** End programmer edit section *** (Ответственный.НомерТелефона CustomAttributes)
        public virtual int НомерТелефона
        {
            get
            {
                // *** Start programmer edit section *** (Ответственный.НомерТелефона Get start)

                // *** End programmer edit section *** (Ответственный.НомерТелефона Get start)
                int result = this.fНомерТелефона;
                // *** Start programmer edit section *** (Ответственный.НомерТелефона Get end)

                // *** End programmer edit section *** (Ответственный.НомерТелефона Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Ответственный.НомерТелефона Set start)

                // *** End programmer edit section *** (Ответственный.НомерТелефона Set start)
                this.fНомерТелефона = value;
                // *** Start programmer edit section *** (Ответственный.НомерТелефона Set end)

                // *** End programmer edit section *** (Ответственный.НомерТелефона Set end)
            }
        }
        
        /// <summary>
        /// РабочаяПочта.
        /// </summary>
        // *** Start programmer edit section *** (Ответственный.РабочаяПочта CustomAttributes)

        // *** End programmer edit section *** (Ответственный.РабочаяПочта CustomAttributes)
        [StrLen(255)]
        public virtual string РабочаяПочта
        {
            get
            {
                // *** Start programmer edit section *** (Ответственный.РабочаяПочта Get start)

                // *** End programmer edit section *** (Ответственный.РабочаяПочта Get start)
                string result = this.fРабочаяПочта;
                // *** Start programmer edit section *** (Ответственный.РабочаяПочта Get end)

                // *** End programmer edit section *** (Ответственный.РабочаяПочта Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Ответственный.РабочаяПочта Set start)

                // *** End programmer edit section *** (Ответственный.РабочаяПочта Set start)
                this.fРабочаяПочта = value;
                // *** Start programmer edit section *** (Ответственный.РабочаяПочта Set end)

                // *** End programmer edit section *** (Ответственный.РабочаяПочта Set end)
            }
        }
        
        /// <summary>
        /// ФИО.
        /// </summary>
        // *** Start programmer edit section *** (Ответственный.ФИО CustomAttributes)

        // *** End programmer edit section *** (Ответственный.ФИО CustomAttributes)
        [StrLen(255)]
        public virtual string ФИО
        {
            get
            {
                // *** Start programmer edit section *** (Ответственный.ФИО Get start)

                // *** End programmer edit section *** (Ответственный.ФИО Get start)
                string result = this.fФИО;
                // *** Start programmer edit section *** (Ответственный.ФИО Get end)

                // *** End programmer edit section *** (Ответственный.ФИО Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Ответственный.ФИО Set start)

                // *** End programmer edit section *** (Ответственный.ФИО Set start)
                this.fФИО = value;
                // *** Start programmer edit section *** (Ответственный.ФИО Set end)

                // *** End programmer edit section *** (Ответственный.ФИО Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ОтветственныйE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОтветственныйE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОтветственныйE", typeof(IIS.Kursovaya.Ответственный));
                }
            }
            
            /// <summary>
            /// "ОтветственныйL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОтветственныйL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОтветственныйL", typeof(IIS.Kursovaya.Ответственный));
                }
            }
        }
    }
}
