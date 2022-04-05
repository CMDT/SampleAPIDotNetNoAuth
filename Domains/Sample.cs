using api.Domains.Interfaces;
using api.DTOs;
using api.Models;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.Configuration;


namespace api.Domains
{
    public class Sample : ISample
    {
        private readonly string domain;

        private readonly Context context;

        private readonly ILogger logger;

        public Sample(Context _context, ILogger<Sample> _logger)
        {
            context = _context;

            logger = _logger;
        }

        public IConfiguration Configuration { get; }

        public void DeleteItem(string id)
        {
            throw new NotImplementedException();
        } 

        public List<SampleDTO> ReadItems()
        {
           throw new NotImplementedException();
        }

        public SampleDTO ReadItem(string id)
        {
            throw new NotImplementedException();
        }

        public SampleDTO EditItem(SampleDTO item)
        {
            throw new NotImplementedException();
        }

        public SampleDTO AddItem(SampleDTO item)
        {
            throw new NotImplementedException();
        }

    }

}
