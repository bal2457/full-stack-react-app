
using Notes.DB;

namespace Notes.Core
{
    public class NotesServices
    {
        private AppDbContext _context;
        public NotesServices(AppDbContext context)
        {
            _context = context;
        }

        public Note CreateNote(Note note)
        {
            _context.Add(note);
            _context.SaveChanges();

            return note;
        }
    }
}
