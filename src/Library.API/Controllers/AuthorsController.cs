using Library.API.Models;
using Library.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    [Route("/api/authors")]
    public class AuthorsController : Controller
    {
        private readonly ILibraryRepository _libraryRepository;

        public AuthorsController(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

        [HttpGet()]
        public IActionResult GetAuthors()
        {
            var authorsFromRepo = _libraryRepository.GetAuthors();

            return new JsonResult(authorsFromRepo);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(Guid id)
        {
            return new JsonResult(new AuthorDto
            {
                Age = 24,
                Id = Guid.Parse("f74d6899-9ed2-4137-9876-66b070553f8f"),
                Genre = "Fiction",
                Name = "Ravi"
            });
        }
    }
}
