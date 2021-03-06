// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using Axe.Windows.Core.Bases;
using Axe.Windows.Core.Enums;
using Axe.Windows.Core.Types;
using Axe.Windows.Rules.Resources;
using static Axe.Windows.Rules.PropertyConditions.StringProperties;

namespace Axe.Windows.Rules.Library
{
    [RuleInfo(ID = RuleId.LocalizedControlTypeNotWhiteSpace)]
    class LocalizedControlTypeIsNotWhiteSpace : Rule
    {
        public LocalizedControlTypeIsNotWhiteSpace()
        {
            this.Info.Description = Descriptions.LocalizedControlTypeNotWhiteSpace;
            this.Info.HowToFix = HowToFix.LocalizedControlTypeNotWhiteSpace;
            this.Info.Standard = A11yCriteriaId.ObjectInformation;
            this.Info.PropertyID = PropertyType.UIA_LocalizedControlTypePropertyId;
            this.Info.ErrorCode = EvaluationCode.Error;
        }

        public override bool PassesTest(IA11yElement e)
        {
            if (e == null) throw new ArgumentNullException(nameof(e));

            return LocalizedControlType.NotWhiteSpace.Matches(e);
        }

        protected override Condition CreateCondition()
        {
            return LocalizedControlType.NotNullOrEmpty;
        }
    } // class
} // namespace
