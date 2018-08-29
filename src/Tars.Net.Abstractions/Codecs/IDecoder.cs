using Tars.Net.Metadata;

namespace Tars.Net.Codecs
{
    public interface IDecoder<T>
    {
        Request DecodeRequest(T input);

        Response DecodeResponse(T input);
    }

    public interface IContentDecoder
    {
        void DecodeRequestContent(Request req);

        void DecodeResponseContent(Response resp);
    }
}