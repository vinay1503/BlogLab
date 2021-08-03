using BlogLabModels.Photo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Repository
{
    public interface IPhotoRepository
    {
        public Task<Photo> InsertAsync(PhotoCreate photoCreate, int appicationUserId);

        public Task<Photo> GetAsync(int photoId);

        public Task<List<Photo>> GetAllByUserAsync(int applicationUserId);

        public Task<int> DeleteAsync(int photoId);
    }
}
