﻿namespace GalleryServer.Infrastructure.Services
{
    using System.Threading.Tasks;

    public interface ISignalRService
    {
        Task ReturnAllPosts();
    }
}
