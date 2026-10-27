import axios from "axios";

export default{
  async obterTasks(){

    return await axios.get("http://localhost:5190/Controller/Queries/listar");
  },

  async obterTasksConcluidas(){

    return await axios.get("/Controller/Queries/concluidas");
  },

  async obterTasksPendentes(){

    return await axios.get("/Controller/Queries/pendentes");
  },

  async obterPorcentTasks(){

    return await axios.get("/Controller/Queries/porcent");
  },

  async enviandoDadosTasks(tarefaParaAdicionar){

    return await axios.post("/Controller/Command", tarefaParaAdicionar);
  },

  async deletarTaskPorId(id){
    return await axios.delete(`/Controller/Command/${id}`);
  },

  async atualizarConcluido(id, concluido) {
    return await axios.patch(`/Controller/Command/${id}`, concluido, {
      headers: { 'Content-Type': 'application/json' }
    });
  },

  //verbos date
  async obterDiaNumero(){
    return await axios.get("/Controller/Queries/diaNumero");
  },

  async obterDiaExtenso(){
    return await axios.get("/Controller/Queries/diaExtenso");
  },

  async obterMesEAno(){
    return await axios.get("/Controller/Queries/mesEano");
  },

  async obterEhoje(){
    return await axios.get("/Controller/Queries/Ehoje​");
  },
}



