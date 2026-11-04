using System.Globalization;
using MediatR;
using Aplicacao.DatasCalendario.ObterDataExtenso.ObterDataExtenso.Query;
namespace Aplicacao.DatasCalendario.ObterDataExtenso.ObterDataExtensoQueryHandler;

 public class ObterDataExtensoQueryHandler : IRequestHandler<ObterDataExtensoQuery, string>
 {
    
    public async Task<string> Handle(ObterDataExtensoQuery request, CancellationToken cancellationToken)
    {
        return await PegarDataTexto();
    }
    
    public async static Task<String> PegarDataTexto()
    
    {
        String Data = DateTime.Now.ToString("dddd", new CultureInfo("pt-Br"));
        return Data;
    }

}
