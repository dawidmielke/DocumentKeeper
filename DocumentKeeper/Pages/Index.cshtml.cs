using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Infrastructure.Repositories;
using ApplicationCore.Models;
using Infrastructure.Interfaces;

namespace Web.Pages.Documents
{
    public class IndexModel : PageModel
    {
        private readonly IDocumentRepository _documentRepository;

        public IndexModel(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        public IEnumerable<Document> Documents { get; set; }

        public void OnGet()
        {
            Documents = _documentRepository.GetAllDocuments();
        }
    }
}
