<script>
import BlocoMaior from './components/BlocoMaior.vue';
import BlocoMaiorRecolhido from './components/BlocoMaiorRecolhido.vue';
import BlocoMenor from './components/BlocoMenor.vue';
import BlocoMenorExpandido from './components/BlocoMenorExpandido.vue';
import tarefasServicos from '@/tarefasServicos';
import BlocoRetorno from './components/BlocoRetorno.vue';

export default{
  name: "App",

  data(){
    return{
      diaNp: 0,
      diap: "",
      mesEanop: "",
      isTodaypv: true,
      tarefasconcluidasp: 0,
      porcentagemp: 0,
      tarefaspendentesp: 0,
      EverdadeiroApp: null,
      MensagemApp: null,

      concluidop: "",
      titulop: "",
      corpop: "",
      classep: "",
      horap: "",

      opAdicionarTarefa: false,
      opBlocoMenorExpandido: false,
      opExibirBlocoMaior: false,
      opBlocoMenor: false,
      opBlocoRetorno: false,
      opCssFormatoHoraErrada: false,
      opCssClasseNaoSelecionada: false,


      mensagemErroObterTasks: "",
      mensagemErroObterTasksConcluidas: "",
      mensagemErroObterTasksPendentes: "",
      mensagemErroObterPorcentTasks: "",
      mensagemErroEnviarDadosTasks: "",
      mensagemErroDeletarTaskPorId: "",
      mensagemErroAtualizarConcluido: "",
      mensagemErroObterDiaNumero:  "",
      mensagemErroObterDiaExtenso: "",
      mensagemErroObterMesEAno: "",
      mensagemErroObterEhoje: "",

      sucessoObterTasks: false,
      sucessoObterTasksConcluidas: false,
      sucessoObterTasksPendentes: false,
      sucessoObterPorcentTasks: false,
      sucessoEnviarDadosTasks: false,
      sucessoDeletarTaskPorId: false,
      sucessoAtualizarConcluido: false,
      sucessoObterDiaNumero: false,
      sucessoObterDiaExtenso: false,
      sucessoObterMesEAno: false,
      sucessoObterEhoje: false,


      listaTarefas: [],
      listaBools: [],
    }
  },

  async mounted(){

    //tasks + blocoMenorExpandido
      this.listaTarefas = (await tarefasServicos.obterTasks()).data;
      this.sucessoObterTasks = (await tarefasServicos.obterTasks()).deuCerto;
      this.mensagemErroObterTasks = (await tarefasServicos.obterTasks()).mensagem;
      console.log(this.listaTarefas)

      this.tarefasconcluidasp =  (await tarefasServicos.obterTasksConcluidas()).data;
      this.sucessoObterTasksConcluidas = (await tarefasServicos.obterTasksConcluidas()).deuCerto;
      this.mensagemErroObterTasksConcluidas = (await tarefasServicos.obterTasksConcluidas()).mensagem;

      this.tarefaspendentesp =  (await tarefasServicos.obterTasksPendentes()).data;
      this.sucessoObterTasksPendentes = (await tarefasServicos.obterTasksPendentes()).deuCerto;
      this.mensagemErroObterTasksPendentes = (await tarefasServicos.obterTasksPendentes()).mensagem;

      this.porcentagemp =  (await tarefasServicos.obterPorcentTasks()).data;
      this.sucessoObterPorcentTasks = (await tarefasServicos.obterPorcentTasks()).deuCerto;
      this.mensagemErroObterPorcentTasks = (await tarefasServicos.obterPorcentTasks()).mensagem;


    //date
      this.diaNp =  (await tarefasServicos.obterDiaNumero()).data;
      this.sucessoObterDiaNumero = (await tarefasServicos.obterDiaNumero()).deuCerto;
      this.mensagemErroObterDiaNumero = (await tarefasServicos.obterDiaNumero()).mensagem;


      this.diap =  (await tarefasServicos.obterDiaExtenso()).data;
      this.sucessoObterDiaExtenso = (await tarefasServicos.obterDiaExtenso()).deuCerto;
      this.mensagemErroObterDiaExtenso = (await tarefasServicos.obterDiaExtenso()).mensagem;


      this.mesEanop =  (await tarefasServicos.obterMesEAno()).data;
      this.sucessoObterMesEAno = (await tarefasServicos.obterMesEAno()).deuCerto;
      this.mensagemErroObterMesEAno = (await tarefasServicos.obterMesEAno()).mensagem;

      this.isTodaypv =  (await tarefasServicos.obterEhoje()).data;
      this.sucessoObterEhoje = (await tarefasServicos.obterEhoje()).deuCerto;
      this.mensagemErroObterEhoje = (await tarefasServicos.obterEhoje()).mensagem;

      this.listaBools = [this.sucessoObterTasks, this.sucessoObterTasksConcluidas, this.sucessoObterTasksPendentes, this.sucessoObterPorcentTasks, this.sucessoObterDiaNumero, this.sucessoObterDiaExtenso, this.sucessoObterMesEAno, this.sucessoObterEhoje];

    },

  methods:{

      async MensagemRetornoTarefasEnviadas(valor){
      this.opBlocoRetorno = true;
      this.MensagemApp = valor.mensagem;
      this.EverdadeiroApp = valor.deuCerto;
    },

    fecharMensagemRetorno() {
      this.opBlocoRetorno = false;
    },

    async atualizar(){
      this.listaTarefas = (await tarefasServicos.obterTasks()).data;
      this.sucessoObterTasks = (await tarefasServicos.obterTasks()).deuCerto;
      this.mensagemErroObterTasks = (await tarefasServicos.obterTasks()).mensagem;
      console.log(this.listaTarefas)

      this.tarefasconcluidasp =  (await tarefasServicos.obterTasksConcluidas()).data;
      this.sucessoObterTasksConcluidas = (await tarefasServicos.obterTasksConcluidas()).deuCerto;
      this.mensagemErroObterTasksConcluidas = (await tarefasServicos.obterTasksConcluidas()).mensagem;

      this.tarefaspendentesp =  (await tarefasServicos.obterTasksPendentes()).data;
      this.sucessoObterTasksPendentes = (await tarefasServicos.obterTasksPendentes()).deuCerto;
      this.mensagemErroObterTasksPendentes = (await tarefasServicos.obterTasksPendentes()).mensagem;


      this.porcentagemp =  (await tarefasServicos.obterPorcentTasks()).data;
      this.sucessoObterPorcentTasks = (await tarefasServicos.obterPorcentTasks()).deuCerto;
      this.mensagemErroObterPorcentTasks = (await tarefasServicos.obterPorcentTasks()).mensagem;


    //date
      this.diaNp =  (await tarefasServicos.obterDiaNumero()).data;
      this.sucessoObterDiaNumero = (await tarefasServicos.obterDiaNumero()).deuCerto;
      this.mensagemErroObterDiaNumero = (await tarefasServicos.obterDiaNumero()).mensagem;


      this.diap =  (await tarefasServicos.obterDiaExtenso()).data;
      this.sucessoObterDiaExtenso = (await tarefasServicos.obterDiaExtenso()).deuCerto;
      this.mensagemErroObterDiaExtenso = (await tarefasServicos.obterDiaExtenso()).mensagem;


      this.mesEanop =  (await tarefasServicos.obterMesEAno()).data;
      this.sucessoObterMesEAno = (await tarefasServicos.obterMesEAno()).deuCerto;
      this.mensagemErroObterMesEAno = (await tarefasServicos.obterMesEAno()).mensagem;

      this.isTodaypv =  (await tarefasServicos.obterEhoje()).data;
      this.sucessoObterEhoje = (await tarefasServicos.obterEhoje()).deuCerto;
      this.mensagemErroObterEhoje = (await tarefasServicos.obterEhoje()).mensagem;

      this.listaBools = [this.sucessoObterTasks, this.sucessoObterTasksConcluidas, this.sucessoObterTasksPendentes, this.sucessoObterPorcentTasks, this.sucessoObterDiaNumero, this.sucessoObterDiaExtenso, this.sucessoObterMesEAno, this.sucessoObterEhoje];
    },
  },

  components:{
        BlocoMenorExpandido,
        BlocoMenor,
        BlocoMaior,
        BlocoMaiorRecolhido,
        BlocoRetorno,
  },
}
</script>

<template>
  <BlocoMaior v-if="opExibirBlocoMaior" :diaN="diaNp" :dia="diap" :mesEano="mesEanop" :isToday="isTodaypv" :tarefasConcluidas="tarefasconcluidasp" :porcentagem="porcentagemp" :tarefasPendentes="tarefaspendentesp" @update:opAdicionarTarefa="opBlocoMenorExpandido = true" @update:opExibirBlocoMaior="opExibirBlocoMaior=false; opBlocoMenor = false" >
      <BlocoMenor v-show="opBlocoMenor" :listaTarefas="listaTarefas" @update:opCheckBox="atualizar()"></BlocoMenor>
      <BlocoMenorExpandido v-if="opBlocoMenorExpandido" @mostrar:mensagemRetornoTarefasEnviadas="MensagemRetornoTarefasEnviadas" @salva:pagina="atualizar()" @cancel:task="opBlocoMenorExpandido=false">  </BlocoMenorExpandido>
  </BlocoMaior>
  <BlocoMaiorRecolhido v-else :diaN="diaNp" :diaExtenso="diap" :mesEano="mesEanop" :isToday="isTodaypv" @update:opDetalhes="opExibirBlocoMaior=true; opBlocoMenor = true"></BlocoMaiorRecolhido>
  <BlocoRetorno v-if="opBlocoRetorno" :Everdadeiro="EverdadeiroApp" :mensagem="MensagemApp" @update:opBlocoMenorExpandidoo="opBlocoMenorExpandido = false" @update:opBlocoRetorno="fecharMensagemRetorno()"></BlocoRetorno>

</template>

<style>

body {
  display: block;
  margin: 0;
  background: #f6faf4;
  font-family: system-ui, -apple-system, "Segoe UI", Roboto, sans-serif;
  color: #1f2d1f;
}

#app {
  box-sizing: border-box;
  width: 100%;
  max-width: 488px;
  margin: 0 auto;
  padding: 24px 24px 48px;
  text-align: left;

  display: flex;
  flex-direction: column;
  gap: 12px;
}

/* Todo bloco (maior, recolhido, formulário e tarefas) ocupa a mesma largura e entra com uma animação suave */
#app > * {
  box-sizing: border-box;
  width: 100%;
  flex-shrink: 0;
  animation: surgir 0.2s ease-out;
}

@keyframes surgir {
  from {
    opacity: 0;
    transform: translateY(-6px);
  }
  to {
    opacity: 1;
    transform: none;
  }
}

</style>
