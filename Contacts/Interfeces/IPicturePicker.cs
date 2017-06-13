using System.IO;
using System.Threading.Tasks;

namespace Contacts.Interfeces
{
	public interface IPicturePicker
	{
		Task<Stream> GetImageStreamAsync();
	}
}
