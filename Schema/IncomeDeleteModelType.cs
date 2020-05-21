using HotChocolate.Types;

namespace learnhotchocolate.Schema
{
    public class IncomeDeleteModelType : ObjectType<IncomeDeleteModel>
    {
        protected override void Configure(IObjectTypeDescriptor<IncomeDeleteModel> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(x => x.IncomeId)
            .Type<NonNullType<StringType>>();
        }
    }
}