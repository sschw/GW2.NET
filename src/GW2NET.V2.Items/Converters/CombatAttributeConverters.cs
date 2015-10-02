﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GW2NET.V2.Items.Converters
{
    using System;
    
    using GW2NET.Common;
    using GW2NET.Items;
    using GW2NET.V2.Items;
    using GW2NET.V2.Items.Json;

    public sealed partial class CombatAttributeConverter : IConverter<AttributeDTO, CombatAttribute>
	{
	    private readonly ITypeConverterFactory<AttributeDTO, CombatAttribute> converterFactory;

		public CombatAttributeConverter(ITypeConverterFactory<AttributeDTO, CombatAttribute> converterFactory)
		{
		    if (converterFactory == null)
    		{
    		    throw new ArgumentNullException("converterFactory");
    		}

		    this.converterFactory = converterFactory;
		}

		 /// <inheritdoc />
        CombatAttribute IConverter<AttributeDTO, CombatAttribute>.Convert(AttributeDTO value, object state)
		{
		    if (value == null)
    		{
    		    throw new ArgumentNullException("value");
    		}

			string discriminator = value.Attribute;
			var converter = this.converterFactory.Create(discriminator);
			var entity = converter.Convert(value, value);
			this.Merge(entity, value, state);
			return entity;
		}

		// Implement this method in a buddy class to set properties that are specific to 'CombatAttribute' (if any)
    	partial void Merge(CombatAttribute entity, AttributeDTO dto, object state);

		/*
		// Use this template
		public partial class CombatAttributeConverter
		{
		    partial void Merge(CombatAttribute entity, AttributeDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
	}

#region ConditionDamageModifier
    /// <summary>Converts objects of type <see cref="AttributeDTO"/> to objects of type <see cref="ConditionDamageModifier"/>.</summary>
    public sealed partial class ConditionDamageModifierConverter : IConverter<AttributeDTO, ConditionDamageModifier>
    {
	    /// <inheritdoc />
        public ConditionDamageModifier Convert(AttributeDTO value, object state)
        {    
    		var entity = new ConditionDamageModifier();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'ConditionDamageModifier' (if any)
    	partial void Merge(ConditionDamageModifier entity, AttributeDTO dto, object state);

		/*
		// Use this template
		public partial class ConditionDamageModifierConverter
		{
		    partial void Merge(ConditionDamageModifier entity, AttributeDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region FerocityModifier
    /// <summary>Converts objects of type <see cref="AttributeDTO"/> to objects of type <see cref="FerocityModifier"/>.</summary>
    public sealed partial class FerocityModifierConverter : IConverter<AttributeDTO, FerocityModifier>
    {
	    /// <inheritdoc />
        public FerocityModifier Convert(AttributeDTO value, object state)
        {    
    		var entity = new FerocityModifier();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'FerocityModifier' (if any)
    	partial void Merge(FerocityModifier entity, AttributeDTO dto, object state);

		/*
		// Use this template
		public partial class FerocityModifierConverter
		{
		    partial void Merge(FerocityModifier entity, AttributeDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region HealingModifier
    /// <summary>Converts objects of type <see cref="AttributeDTO"/> to objects of type <see cref="HealingModifier"/>.</summary>
    public sealed partial class HealingModifierConverter : IConverter<AttributeDTO, HealingModifier>
    {
	    /// <inheritdoc />
        public HealingModifier Convert(AttributeDTO value, object state)
        {    
    		var entity = new HealingModifier();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'HealingModifier' (if any)
    	partial void Merge(HealingModifier entity, AttributeDTO dto, object state);

		/*
		// Use this template
		public partial class HealingModifierConverter
		{
		    partial void Merge(HealingModifier entity, AttributeDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region PowerModifier
    /// <summary>Converts objects of type <see cref="AttributeDTO"/> to objects of type <see cref="PowerModifier"/>.</summary>
    public sealed partial class PowerModifierConverter : IConverter<AttributeDTO, PowerModifier>
    {
	    /// <inheritdoc />
        public PowerModifier Convert(AttributeDTO value, object state)
        {    
    		var entity = new PowerModifier();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'PowerModifier' (if any)
    	partial void Merge(PowerModifier entity, AttributeDTO dto, object state);

		/*
		// Use this template
		public partial class PowerModifierConverter
		{
		    partial void Merge(PowerModifier entity, AttributeDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region PrecisionModifier
    /// <summary>Converts objects of type <see cref="AttributeDTO"/> to objects of type <see cref="PrecisionModifier"/>.</summary>
    public sealed partial class PrecisionModifierConverter : IConverter<AttributeDTO, PrecisionModifier>
    {
	    /// <inheritdoc />
        public PrecisionModifier Convert(AttributeDTO value, object state)
        {    
    		var entity = new PrecisionModifier();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'PrecisionModifier' (if any)
    	partial void Merge(PrecisionModifier entity, AttributeDTO dto, object state);

		/*
		// Use this template
		public partial class PrecisionModifierConverter
		{
		    partial void Merge(PrecisionModifier entity, AttributeDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region ToughnessModifier
    /// <summary>Converts objects of type <see cref="AttributeDTO"/> to objects of type <see cref="ToughnessModifier"/>.</summary>
    public sealed partial class ToughnessModifierConverter : IConverter<AttributeDTO, ToughnessModifier>
    {
	    /// <inheritdoc />
        public ToughnessModifier Convert(AttributeDTO value, object state)
        {    
    		var entity = new ToughnessModifier();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'ToughnessModifier' (if any)
    	partial void Merge(ToughnessModifier entity, AttributeDTO dto, object state);

		/*
		// Use this template
		public partial class ToughnessModifierConverter
		{
		    partial void Merge(ToughnessModifier entity, AttributeDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region UnknownModifier
    /// <summary>Converts objects of type <see cref="AttributeDTO"/> to objects of type <see cref="UnknownModifier"/>.</summary>
    public sealed partial class UnknownModifierConverter : IConverter<AttributeDTO, UnknownModifier>
    {
	    /// <inheritdoc />
        public UnknownModifier Convert(AttributeDTO value, object state)
        {    
    		var entity = new UnknownModifier();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'UnknownModifier' (if any)
    	partial void Merge(UnknownModifier entity, AttributeDTO dto, object state);

		/*
		// Use this template
		public partial class UnknownModifierConverter
		{
		    partial void Merge(UnknownModifier entity, AttributeDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region VitalityModifier
    /// <summary>Converts objects of type <see cref="AttributeDTO"/> to objects of type <see cref="VitalityModifier"/>.</summary>
    public sealed partial class VitalityModifierConverter : IConverter<AttributeDTO, VitalityModifier>
    {
	    /// <inheritdoc />
        public VitalityModifier Convert(AttributeDTO value, object state)
        {    
    		var entity = new VitalityModifier();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'VitalityModifier' (if any)
    	partial void Merge(VitalityModifier entity, AttributeDTO dto, object state);

		/*
		// Use this template
		public partial class VitalityModifierConverter
		{
		    partial void Merge(VitalityModifier entity, AttributeDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

}