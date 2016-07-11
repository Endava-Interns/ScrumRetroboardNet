using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using EndavaScrum.Models;
<<<<<<< HEAD
using System.Text;

namespace EndavaScrum.Controllers {
    public class SessionsController : ApiController {
        private DbEntities db = new DbEntities();

        // GET: api/Sessions
        public IQueryable<Session> GetSessions() {
=======

namespace EndavaScrum.Controllers
{
    public class SessionsController : ApiController
    {
        private DbEntities db = new DbEntities();

        // GET: api/Sessions
        public IQueryable<Session> GetSessions()
        {
>>>>>>> master
            return db.Sessions;
        }

        // GET: api/Sessions/5
        [ResponseType(typeof(Session))]
<<<<<<< HEAD
        public IHttpActionResult GetSession(string id) {
            Session session = db.Sessions.Find(id);
            if (session == null) {
=======
        public IHttpActionResult GetSession(string id)
        {
            Session session = db.Sessions.Find(id);
            if (session == null)
            {
>>>>>>> master
                return NotFound();
            }

            return Ok(session);
        }

        // PUT: api/Sessions/5
        [ResponseType(typeof(void))]
<<<<<<< HEAD
        public IHttpActionResult PutSession(string id, Session session) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != session.session_id) {
=======
        public IHttpActionResult PutSession(string id, Session session)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != session.session_id)
            {
>>>>>>> master
                return BadRequest();
            }

            db.Entry(session).State = EntityState.Modified;

<<<<<<< HEAD
            try {
                db.SaveChanges();
            } catch (DbUpdateConcurrencyException) {
                if (!SessionExists(id)) {
                    return NotFound();
                } else {
=======
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SessionExists(id))
                {
                    return NotFound();
                }
                else
                {
>>>>>>> master
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Sessions
        [ResponseType(typeof(Session))]
<<<<<<< HEAD
        public IHttpActionResult PostSession(Session session) {
            if (!ModelState.IsValid) {
=======
        public IHttpActionResult PostSession(Session session)
        {
            if (!ModelState.IsValid)
            {
>>>>>>> master
                return BadRequest(ModelState);
            }

            db.Sessions.Add(session);

<<<<<<< HEAD
            try {
                db.SaveChanges();
            } catch (DbUpdateException) {
                if (SessionExists(session.session_id)) {
                    return Conflict();
                } else {
=======
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (SessionExists(session.session_id))
                {
                    return Conflict();
                }
                else
                {
>>>>>>> master
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = session.session_id }, session);
        }

        // DELETE: api/Sessions/5
        [ResponseType(typeof(Session))]
<<<<<<< HEAD
        public IHttpActionResult DeleteSession(string id) {
            Session session = db.Sessions.Find(id);
            if (session == null) {
=======
        public IHttpActionResult DeleteSession(string id)
        {
            Session session = db.Sessions.Find(id);
            if (session == null)
            {
>>>>>>> master
                return NotFound();
            }

            db.Sessions.Remove(session);
            db.SaveChanges();

            return Ok(session);
        }

<<<<<<< HEAD
        protected override void Dispose(bool disposing) {
            if (disposing) {
=======
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
>>>>>>> master
                db.Dispose();
            }
            base.Dispose(disposing);
        }

<<<<<<< HEAD
        private bool SessionExists(string id) {
            return db.Sessions.Count(e => e.session_id == id) > 0;
        }

        [Route("api/Sessions/{id}/Modified")]
        [HttpGet]
        public IHttpActionResult IsSessionModified(string id) {
            if (!SessionExists(id)) {
                return NotFound();
            }
            Session session = db.Sessions.Find(id);
            return Ok(session.is_changed);
        }

        [Route("api/Sessions/ActiveSessions")]
        [HttpGet]
        public IHttpActionResult GetActiveSessionsNumber() {
            return Ok(db.Sessions.Count());
        }
=======
        private bool SessionExists(string id)
        {
            return db.Sessions.Count(e => e.session_id == id) > 0;
        }
>>>>>>> master
    }
}