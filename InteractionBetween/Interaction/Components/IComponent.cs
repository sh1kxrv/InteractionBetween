using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionBetween.Interaction.Components
{
    /// <summary>
    /// Компонент для существ или же объектов, к примеру - хранение предмета.
    /// </summary>
    public interface IComponent
    {
        string ComponentName { get; set; }
    }
}
