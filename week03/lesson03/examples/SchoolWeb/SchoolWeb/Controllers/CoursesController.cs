using AutoMapper;
using SchoolWeb.Models;
using SchoolWeb.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolWeb.Controllers
{
    public class CoursesController : ApiController
    {
        private SchoolContext context;

        public CoursesController()
        {
            context = new SchoolContext();
        }

        // GET api/courses
        public IEnumerable<CourseDTO> GetAll()
        {
            return context.Course.ToList().Select(Mapper.Map<Course, CourseDTO>);
        }

        // GET api/courses/1
        //public CourseDTO Get(int id)
        //{
        //    var course = context.Course.FirstOrDefault(c => c.Id == id);

        //    if (course == null)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);

        //    return Mapper.Map<Course, CourseDTO>(course);
        //}

        public IHttpActionResult Get(int id)
        {
            var course = context.Course.FirstOrDefault(c => c.Id == id);

            if (course == null)
                NotFound();

            return Ok(Mapper.Map<Course, CourseDTO>(course));
        }

        // POST api/courses
        //[HttpPost]
        //public CourseDTO Create(CourseDTO dto)
        //{
        //    if (!ModelState.IsValid)
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);

        //    var course = Mapper.Map<CourseDTO, Course>(dto);

        //    context.Course.Add(course);
        //    context.SaveChanges();

        //    dto.Id = course.Id;

        //    return dto;
        //}

        [HttpPost]
        public IHttpActionResult Create(CourseDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var course = Mapper.Map<CourseDTO, Course>(dto);

            context.Course.Add(course);
            context.SaveChanges();

            dto.Id = course.Id;

            return Created(new Uri($"{Request.RequestUri}/{course.Id}"), dto);
        }

        // PUT /api/courses/id
        [HttpPut]
        public CourseDTO Update(int id, CourseDTO dto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var courseToUpdate = context.Course.FirstOrDefault(c => c.Id == id);

            if (courseToUpdate == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            // No requiere mappear propiedades dado para guardar dado que se encuentra en el mismo contexto (referencia)
            Mapper.Map(dto, courseToUpdate);

            context.SaveChanges();

            return dto;
        }

        // DELETE /api/courses/id
        [HttpDelete]
        public void Delete(int id)
        {
            var courseToDelete = context.Course.FirstOrDefault(c => c.Id == id);

            if (courseToDelete == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            context.Course.Remove(courseToDelete);
            context.SaveChanges();
        }
    }
}
