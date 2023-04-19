using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT_Assignment02.EBooks.Services;

namespace Sliit.MTIT_Assignment02.EBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EBooksController : ControllerBase
    {
        private readonly IEBooksService _ebooksService;

        public EBooksController(IEBooksService ebooksService)
        {
            _ebooksService = ebooksService ?? throw new ArgumentNullException(nameof(ebooksService));
        }

        /// <summary>
        /// Get all ebooks
        /// </summary>
        /// <returns>Returns a list of all ebooks</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ebooksService.GetEBooks());
        }

        /// <summary>
        /// Get ebook by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the ebook with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _ebooksService.GetEBook(id) != null ? Ok(_ebooksService.GetEBook(id)) : NoContent();
        }

        /// <summary>
        /// Add ebooks
        /// </summary>
        /// <param name="ebook"></param>
        /// <returns>Return the added ebook</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.EBooks ebook)
        {
            return Ok(_ebooksService.AddEBook(ebook));
        }

        /// <summary>
        /// Update the ebook
        /// </summary>
        /// <param name="ebook"></param>
        /// <returns>Return the updated ebook</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.EBooks ebook)
        {
            return Ok(_ebooksService.UpdateEBook(ebook));
        }

        /// <summary>
        /// Delete the ebook with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns a response indicating whether the ebook was deleted successfully or not</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _ebooksService.DeleteEBook(id);

            return result.HasValue && result.Value == true ? Ok($"Ebook with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the ebook with ID:{id}.");
        }
    }
}
