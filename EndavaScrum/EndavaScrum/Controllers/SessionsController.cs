using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using EndavaScrum.Models;
using System.Web.Http.Cors;

namespace EndavaScrum.Controllers
{
    //[EnableCors(origins: "https://endava-scrum-dev.herokuapp.com/", headers: "*", methods: "*")]
    public class SessionsController : ApiController {
        private IDbEntities db = new DbEntities();

        public SessionsController() { }

        public SessionsController(IDbEntities context)
        {
            db = context;
        }

        // GET: api/Sessions
        public IQueryable<Session> GetSessions() {
            return db.Sessions;
        }

        // GET: api/Sessions/5
        [ResponseType(typeof(Session))]
        public IHttpActionResult GetSession(string id) {
            Session session = db.Sessions.Find(id);
            if (session == null) {
                return NotFound();
            }

            return Ok(session);
        }

        // PUT: api/Sessions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSession(string id, Session session) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != session.session_id) {
                return BadRequest();
            }

            db.MarkAsModified(session);

            try {
                db.SaveChanges();
            } catch (DbUpdateConcurrencyException) {
                if (!SessionExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Sessions
        [ResponseType(typeof(Session))]
        public IHttpActionResult PostSession(Session session) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Sessions.Add(session);

            try {
                db.SaveChanges();
            } catch (DbUpdateException) {
                if (SessionExists(session.session_id)) {
                    return Conflict();
                } else {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = session.session_id }, session);
        }

        // DELETE: api/Sessions/5
        [ResponseType(typeof(Session))]
        public IHttpActionResult DeleteSession(string id) {
            Session session = db.Sessions.Find(id);
            if (session == null) {
                return NotFound();
            }

            db.Sessions.Remove(session);
            db.SaveChanges();

            return Ok(session);
        }

        protected override void Dispose(bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

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
    }
}