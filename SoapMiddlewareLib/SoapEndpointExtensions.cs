//using Microsoft.AspNetCore.Builder;
//using System.ServiceModel.Channels;

//namespace SoapMiddlewareLib
//{
//    namespace Microsoft.AspNetCore.Builder
//    {
//        // Extension method used to add the middleware to the HTTP request pipeline.
//        public static class SOAPEndpointExtensions
//        {
//            public static IApplicationBuilder UseSOAPEndpoint<T>(this IApplicationBuilder builder, string path, MessageEncoder encoder)
//            {
//                return builder.UseMiddleware<SOAPEndpointMiddleware>(typeof(T), path, encoder);
//            }

//            public static IApplicationBuilder UseSOAPEndpoint<T>(this IApplicationBuilder builder, string path, Binding binding)
//            {
//                var encoder = binding.CreateBindingElements().Find<MessageEncodingBindingElement>()?.CreateMessageEncoderFactory().Encoder;
//                return builder.UseMiddleware<SOAPEndpointMiddleware>(typeof(T), path, encoder);
//            }

//            public static IApplicationBuilder UseSOAPEndpoint(this IApplicationBuilder builder)
//            {
//                return builder.UseMiddleware<SOAPEndpointMiddleware>();
//            }
//        }
//    }
//}
