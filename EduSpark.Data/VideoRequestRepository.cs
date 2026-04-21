using EduSpark.Core.Entities;
using EduSpark.Data;
using EduSpark.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduSpark.Data
{
    public class VideoRequestRepository : IVideoRequestRepository
    {
        private readonly EduSparkDB _context;

        public VideoRequestRepository(EduSparkDB context)
        {
            _context = context;
        }

        public async Task<IEnumerable<VideoRequest>> GetAllAsync()
        {
            return await _context.VideoRequests.Include(v => v.User).ToListAsync();
        }

        public async Task<VideoRequest?> GetByIdAsync(int id)
        {
            return await _context.VideoRequests.Include(v => v.User).FirstOrDefaultAsync(v => v.VideoRequestId == id);
        }

        public async Task<IEnumerable<VideoRequest>> GetByUserIdAsync(int userId)
        {
            return await _context.VideoRequests.Include(v => v.User).Where(v => v.UserId == userId).ToListAsync();
        }

        public async Task<VideoRequest> AddAsync(VideoRequest videoRequest)
        {
            _context.VideoRequests.Add(videoRequest);
            await _context.SaveChangesAsync();
            return videoRequest;
        }

        public async Task<VideoRequest> UpdateAsync(VideoRequest videoRequest)
        {
            _context.VideoRequests.Update(videoRequest);
            await _context.SaveChangesAsync();
            return videoRequest;
        }

        public async Task DeleteAsync(int id)
        {
            var videoRequest = await GetByIdAsync(id);
            if (videoRequest != null)
            {
                _context.VideoRequests.Remove(videoRequest);
                await _context.SaveChangesAsync();
            }
        }
    }
}