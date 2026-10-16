import axios from "axios";

export default{
  async obterTasks(){

    return await axios.get("http://localhost:5190/Routes/TaskRoutes/todas");
  },

  async obterTasksConcluidas(){

    return await axios.get("/Routes/TaskRoutes/concluidas");
  },

  async obterTasksPendentes(){

    return await axios.get("/Routes/TaskRoutes/pendentes");
  },

  async obterPorcentTasks(){

    return await axios.get("/Routes/TaskRoutes/porcent");
  },

  async enviandoDadosTasks(tarefaParaAdicionar){

    return await axios.post("/Routes/TaskRoutes", tarefaParaAdicionar);
  },

  async deletarTaskPorId(id){
    return await axios.delete(`/Routes/TaskRoutes/${id}`);
  },

  async atualizarConcluido(id, concluido) {
    return await axios.patch(`/Routes/TaskRoutes/${id}`, concluido, {
      headers: { 'Content-Type': 'application/json' }
    });
  },

  //verbos date
  async obterDiaNumero(){
    return await axios.get("/Routes/TaskRoutes/diaNumero");
  },

  async obterDiaExtenso(){
    return await axios.get("/Routes/TaskRoutes/diaExtenso");
  },

  async obterMesEAno(){
    return await axios.get("/Routes/TaskRoutes/mesEano");
  },

  async obterEhoje(){
    return await axios.get("/Routes/TaskRoutes/Ehoje");
  },
}



