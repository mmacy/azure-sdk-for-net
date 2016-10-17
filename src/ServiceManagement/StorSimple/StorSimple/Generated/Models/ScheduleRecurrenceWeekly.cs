// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// Backup policy weekly recurring schedule.
    /// </summary>
    public partial class ScheduleRecurrenceWeekly : ScheduleRecurrence
    {
        private IList<DayOfWeek> _weekDays;
        
        /// <summary>
        /// Required. The week days list for this recurrence.
        /// </summary>
        public IList<DayOfWeek> WeekDays
        {
            get { return this._weekDays; }
            set { this._weekDays = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ScheduleRecurrenceWeekly class.
        /// </summary>
        public ScheduleRecurrenceWeekly()
        {
            this.WeekDays = new List<DayOfWeek>();
        }
        
        /// <summary>
        /// Initializes a new instance of the ScheduleRecurrenceWeekly class
        /// with required arguments.
        /// </summary>
        public ScheduleRecurrenceWeekly(List<DayOfWeek> weekDays, RecurrenceType recurrenceType, int recurrenceValue)
            : this()
        {
            if (weekDays == null)
            {
                throw new ArgumentNullException("weekDays");
            }
            this.WeekDays = weekDays;
            this.RecurrenceType = recurrenceType;
            this.RecurrenceValue = recurrenceValue;
        }
    }
}