using System;
using Ozeki.Media;
using Ozeki.Media.IPCamera;
using Ozeki.Media.MediaHandlers;
using Ozeki.Media.MediaHandlers.Video;
using Ozeki.Media.Video.Controls;

namespace ONVIFClient
{

    public class ONVIFClient
    {
        private IIPCamera _camera;
        private DrawingImageProvider _imageProvider;
        private MediaConnector _connector;
        private VideoViewerWF _videoViewerWf;

        public ONVIFClient()
        {
            _imageProvider = new DrawingImageProvider();
            _connector = new MediaConnector();
            _videoViewerWf = new VideoViewerWF();

            //_camera = new Ozeki.Media.IPCamera.IIPCameraClient("192.168.112.109:8080", "user", "qwe123");
            //_connector.Connect(_camera.VideoChannel, _imageProvider);
            //_camera.Start();
        }
    }
}
