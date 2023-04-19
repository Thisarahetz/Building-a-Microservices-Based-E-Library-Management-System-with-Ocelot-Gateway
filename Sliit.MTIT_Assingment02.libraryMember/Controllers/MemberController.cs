using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT_Assignment02.Members.Models;
using Sliit.MTIT_Assignment02.Members.Services;

namespace Sliit.MTIT_Assingment02.libraryMember.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class MembersController : ControllerBase
        {
            private readonly IMembersService _memberService;

            public MembersController(IMembersService memberService)
            {
                _memberService = memberService ?? throw new ArgumentNullException(nameof(memberService));
            }

            /// <summary>
            /// Get all members
            /// </summary>
            /// <returns>return the list of members</returns>
            [HttpGet]
            public IActionResult Get()
            {
                return Ok(_memberService.GetMembers());
            }

            /// <summary>
            /// Get member by ID
            /// </summary>
            /// <param name="id"></param>
            /// <returns>Return the member with the passed ID</returns>
            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                return _memberService.GetMember(id) != null ? Ok(_memberService.GetMember(id)) : NoContent();
            }

            /// <summary>
            /// Add members
            /// </summary>
            /// <param name="member"></param>
            /// <returns>Return the added member</returns>
            [HttpPost]
            public IActionResult Post([FromBody] Members member)
            {
                return Ok(_memberService.AddMember(member));
            }

            /// <summary>
            /// Update the member
            /// </summary>
            /// <param name="member"></param>
            /// <returns>Return the updated member</returns>
            [HttpPut]
            public IActionResult Put([FromBody] Members member)
            {
                return Ok(_memberService.UpdateMember(member));
            }

            /// <summary>
            /// Delete the member with the passed ID
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                var result = _memberService.DeleteMember(id);

                return result.HasValue && result.Value
                    ? Ok($"Member with ID:{id} got deleted successfully.")
                    : BadRequest($"Unable to delete the member with ID:{id}.");
            }
        }
    
}
