using Neo;
using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Native;

namespace DevHawk.Contracts
{
    public partial class ApocToken : SmartContract
    {
        private static bool ValidateAddress(UInt160 address) => address.IsValid && !address.IsZero;
        private static bool IsDeployed(UInt160 address) => ContractManagement.GetContract(address) != null;
    }
}
