﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SampleAPI.Commands;
using SampleAPI.Domain;
using SampleAPI.Domain.Behaviors;
using SampleAPI.Domain.Managers;
using SampleAPI.Domain.Models;
using SampleAPI.Queries;
using SampleAPI.ViewModels;


namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersCoursesController : ControllerBase
    {
        private readonly IUserCourseBehavior _behavior;

        private readonly ICourseBehavior _courseBehavior;

        private readonly IUserCourseQueries _queries;

        private readonly IUserQueries _userQueries;

        private readonly ICourseQueries _courseQueries;

        private readonly IMapper _mapper;

        public UsersCoursesController(IUserCourseBehavior behavior, ICourseBehavior courseBehavior, IUserCourseQueries queries, ICourseQueries courseQueries, IUserQueries userQueries,   IMapper mapper)
        {
            _behavior = behavior;
            _queries = queries;
            _mapper = mapper;
            _courseQueries = courseQueries;
            _courseBehavior = courseBehavior;
            _userQueries = userQueries;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<IEnumerable<UserCourseViewModel>>> GetAllAsync()
        {
            return await _queries.FindAllAsync();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<UserCourseViewModel>> GetByIdAsync(int id)
        {
            var existingUserCourse = await _queries.FindByIdAsync(id);
            if (existingUserCourse == null)
            {
                return NotFound();
            }
            return existingUserCourse;
        }

        [Route("ByUser/{Username}")]
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<IEnumerable<UserCourseViewModel>>> GetAllByUsernameAsync(string Username)
        {
            return await _queries.FindAllByUsernameAsync(Username);
        }

        [Route("ByCourse/{CourseId}")]
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<IEnumerable<UserCourseViewModel>>> GetAllByCourseIdAsync(int CourseId)
        {
            return await _queries.FindAllByCourseIdAsync(CourseId);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        [ProducesResponseType(409)]
        public async Task<ActionResult<UserCourse>> CreateUserCourseAsync(CreateUserCourseCommand createUserCourseCommand)
        {
            var username = createUserCourseCommand.Username;
            var courseId = createUserCourseCommand.CourseId;

            var existingUser = await _userQueries.FindByUsernameAsync(username);
            var existingCourse = await _courseQueries.FindByIdAsync(courseId);

            if (existingUser == null || existingCourse == null)
            {
                return NotFound();
            }

            var existingRegister = await _queries.FindExistUserCourseAsync(username, courseId);
            if (existingRegister != null)
            {
                return Conflict();
            }

            var userCourse = _mapper.Map<UserCourse>(createUserCourseCommand);
            await _behavior.CreateUserCourseAsync(userCourse);
            return CreatedAtAction(
                nameof(GetByIdAsync),
                new { id = userCourse.Id },
                _mapper.Map<BasicUserCourseViewModel>(userCourse));
        }

        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateRatingUserCourseAsync(int id, UpdateUserCourseCommand updateUserCourseCommand)
        {

            var existingUserCourse = await _queries.FindByIdAsync(id);

            if (existingUserCourse == null)
            {
                return NotFound();
            }

            var courseId = existingUserCourse.CourseId;
            var existingCourse = await _courseQueries.FindByIdAsync(courseId);

            if (existingCourse == null)
            {
                return NotFound();
            }


            UserCourse userCourseUpdated = _mapper.Map<UserCourse>(existingUserCourse);
            _mapper.Map(updateUserCourseCommand, userCourseUpdated);
            await _behavior.UpdateRatingUserCourseAsync(userCourseUpdated);

            var averageCourse = await _queries.AverageCourseAsync(courseId);
            Course courseUpdated = _mapper.Map<Course>(existingCourse);
            await _courseBehavior.UpdateRatingCourseAsync(courseUpdated, averageCourse);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteUserCourseAsync(int id)
        {
            var existingUserCourse = await _queries.FindByIdAsync(id);
            if (existingUserCourse == null)
            {
                return NotFound();
            }


            UserCourse userCourseDeleted = _mapper.Map<UserCourse>(existingUserCourse);
            await _behavior.DeleteUserCourseAsync(userCourseDeleted);
            return NoContent();
        }
    }
}
