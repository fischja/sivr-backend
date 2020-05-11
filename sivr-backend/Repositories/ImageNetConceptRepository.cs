using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using sivr_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace sivr_backend.Repositories
{
    public class ImageNetConceptRepository : IImageNetConceptRepository
    {
        private SivrContext _context;

        public ImageNetConceptRepository(SivrContext context)
        {
            _context = context;
        }

        public IEnumerable<QueryResultDTO> GetConceptMatches(int conceptId, string colorId, int queryMode)
        {
            if (queryMode == 0)
            {
                if (conceptId >= 1000)
                {
                    return _context.OpenImagesConceptScores
                        .Where(x => x.OpenImagesConceptId == conceptId)
                        .OrderByDescending(x => x.Score)
                        .Take(203)
                        .Select(x => new QueryResultDTO() { V3CId = x.V3CId, KeyframeNumber = x.KeyframeNumber });
                }
                else
                {
                    return _context.ImageNetConceptScores
                        .Where(x => x.ImageNetConceptId == conceptId)
                        .OrderByDescending(x => x.Score)
                        .Take(203)
                        .Select(x => new QueryResultDTO() { V3CId = x.V3CId, KeyframeNumber = x.KeyframeNumber });
                }
            }
            else if (queryMode == 2)
            {
                return _context.ColorScores
                .Where(x => x.ColorId == colorId)
                .OrderBy(x => x.Score)
                .Take(203)
                .Select(x => new QueryResultDTO() { V3CId = x.V3CId, KeyframeNumber = x.KeyframeNumber });
            }
            else 
            {
                if (conceptId >= 1000)
                {
                    return _context.OpenImagesConceptScores
                        .Where(x => x.OpenImagesConceptId == conceptId)
                        .OrderByDescending(x => x.Score)
                        .Take(203)
                        .ToList()
                        .Select(x => new
                        {
                            V3CId = x.V3CId,
                            KeyframeNumber = x.KeyframeNumber,
                            Score = _context.ColorScores.Find(x.V3CId, x.KeyframeNumber, colorId).Score
                        })
                        .OrderBy(x => x.Score)
                        .Select(x => new QueryResultDTO() { V3CId = x.V3CId, KeyframeNumber = x.KeyframeNumber });
                }
                else
                {
                    return _context.ImageNetConceptScores
                        .Where(x => x.ImageNetConceptId == conceptId)
                        .OrderByDescending(x => x.Score)
                        .Take(203)
                        .ToList()
                        .Select(x => new
                        {
                            V3CId = x.V3CId,
                            KeyframeNumber = x.KeyframeNumber,
                            Score = _context.ColorScores.Find(x.V3CId, x.KeyframeNumber, colorId).Score
                        })
                        .OrderBy(x => x.Score)
                        .Select(x => new QueryResultDTO() { V3CId = x.V3CId, KeyframeNumber = x.KeyframeNumber });
                }
            }
        }

        public Dictionary<string, short> GetNameToIdMap()
        {
            var _imageNetConceptNames = _context.ImageNetConceptNames
                .ToDictionary(x => x.Name, x => x.ImageNetConceptId);
            var _openImagesConceptNames = _context.OpenImagesConcepts
                .ToDictionary(x => x.OpenImagesConceptName, x => x.OpenImagesConceptId);

            return _imageNetConceptNames.Concat(_openImagesConceptNames)
                .GroupBy(kvp => kvp.Key, kvp => kvp.Value)
                .ToDictionary(g => g.Key, g => g.Last());
        }
    }
}
