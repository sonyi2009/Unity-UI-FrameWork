﻿using System.Collections.Generic;
using UnityEngine.Events;

namespace Assets.Scripts.Service.Core
{
    public class ModuleEvent : UnityEvent<object>
    {

    }

    public class ModuleEvent<T> : UnityEvent<T>
    {

    }


    public class EventTable
    {
        private Dictionary<string, ModuleEvent> m_mapEvents;


        /// <summary>
        /// 获取Type所指定的ModuleEvent（它其实是一个EventTable）
        /// 如果不存在，则实例化一个
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public ModuleEvent GetEvent(string type)
        {
            if (m_mapEvents == null)
            {
                m_mapEvents = new Dictionary<string, ModuleEvent>();
            }
            if (!m_mapEvents.ContainsKey(type))
            {
                m_mapEvents.Add(type, new ModuleEvent());
            }
            return m_mapEvents[type];
        }

        public void Clear()
        {
            if (m_mapEvents != null)
            {
                foreach (var @event in m_mapEvents)
                {
                    @event.Value.RemoveAllListeners();
                }
                m_mapEvents.Clear();
            }
        }

    }
}
