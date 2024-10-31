using System.Collections.Generic;
using System.IO;
using Application.Dto;
using Application.IServices;
using DataAccess.Entities;
using DataAccess.Repostories.DbIndexs;

namespace Application.Services
{
    public class IndexService : IIndexService
    {
        private readonly IIndexRepository _indexRepository;

        public IndexService(IIndexRepository indexRepository)
        {
            _indexRepository = indexRepository;
        }

        public void Create(CreateIndexDto dto)
        {
            var dbindex = new DbIndex
            {
                Index = dto.Index,
                District = dto.District,
                Region = dto.Region,
                City = dto.City,
                Street = dto.Street,
                NumberStreet = dto.NumberStreet
            };

            _indexRepository.Create(dbindex);
        }


        
        public int FindIndex(FindIndexDto index)
        {
            var existingIndex = _indexRepository.GetAll() 
                    .FirstOrDefault(i => i.District == index.District
                                      && i.Region == index.Region
                                      && i.City == index.City
                                      && i.Street == index.Street
                                      && i.NumberStreet == index.NumberStreet);

            if (existingIndex != null)
            {
            return existingIndex.Index;
            }
            else
            {
            throw new ArgumentException("Index record not found.");
            }
        }
       
        public void Delete(int id)
        {
            _indexRepository.Delete(id);
        }

        public IndexDto Get(long id)
        {
            var dbIndex = _indexRepository.Get(id);
            return dbIndex != null ? ConvertToIndexDto(dbIndex) : null;
        }

        public List<IndexDto> GetAll()
        {
  
            var indices = _indexRepository.GetAll();
            var indexDto = indices.Select(i => new IndexDto
            {
                Id = i.Id,
                Index = i.Index,
                District = i.District,
                Region = i.Region,
                City = i.City,
                Street = i.Street,
                NumberStreet = i.NumberStreet
            }).ToList();

            return indexDto;
        }


        private IndexDto ConvertToIndexDto(DbIndex dbIndex)
        {
            return new IndexDto
            {
                Id = dbIndex.Id,
                Index = dbIndex.Index,
                District = dbIndex.District,
                Region = dbIndex.Region,
                City = dbIndex.City,
                Street = dbIndex.Street,
                NumberStreet = dbIndex.NumberStreet
            };
        }
        public List<IndexDto> Search(string district, string region, string city, string street, string numberStreet)
        {
            var dbIndexes = _indexRepository.Search(district, region, city, street, numberStreet);

            var indexDtos = dbIndexes.Select(index => new IndexDto
            {
                Id = index.Id,
                Index = index.Index,
                District = index.District,
                Region = index.Region,
                City = index.City,
                Street = index.Street,
                NumberStreet = index.NumberStreet
            }).ToList();

            return indexDtos;
        }

       
        

        public void Update(IndexDto index)
        {
           
            var existingIndex = _indexRepository.GetById(index.Id);

           
            if (existingIndex != null)
            {
                existingIndex.Index = index.Index;
                existingIndex.District = index.District;
                existingIndex.Region = index.Region;
                existingIndex.City = index.City;
                existingIndex.Street = index.Street;
                existingIndex.NumberStreet = index.NumberStreet;

               
                _indexRepository.Update(existingIndex);
            }
            else
            {
                throw new ArgumentException("Index record not found.");
            }
        }
    }

    }

