namespace Aplicacao.DatasCalendario.ObterDataMesAnoExtenso.QueryHandler;
using System.Globalization;
using Aplicacao.DatasCalendario.ObterDataMesAnoExtenso.Query;
using MediatR;

public class ObterDataMeseAnoExtensoQueryHandler : IRequestHandler<ObterDataMeseAnoExtensoQuery, string>
{
    
    public async Task<string> Handle(ObterDataMeseAnoExtensoQuery request, CancellationToken cancellationToken)
    {
        return await PegarMeseAno();
    }
    public async static Task<string> PegarMeseAno()
    {
        String Data = DateTime.Now.ToString("dd 'de' MMMM yyyy", new CultureInfo("pt-Br"));
        return Data;
    }
}
