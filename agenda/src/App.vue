<script>
import BlocoMaior from './components/BlocoMaior.vue';
import BlocoMaiorRecolhido from './components/BlocoMaiorRecolhido.vue';
import BlocoMenor from './components/BlocoMenor.vue';
import BlocoMenorExpandido from './components/BlocoMenorExpandido.vue';

export default{
  name: "App",

  data(){
    return{
      diaNp: Number,
      diap: "",
      mesEanop: "",
      isTodaypv: "",
      tarefasconcluidasp: "",
      porcentagemp: "",
      tarefaspendentesp: "",

      concluidop: "",
      titulop: "",
      corpop: "",
      classep: "",
      horap: "",

      opAdicionarTarefa: Boolean,
      opExibirBlocoMaior: Boolean,
      taskPackage: null,
    }
  },

  methods:{

  },

  components:{
        BlocoMenorExpandido,
        BlocoMenor,
        BlocoMaior,
        BlocoMaiorRecolhido,
  },
}
</script>

<template>

  <BlocoMaior v-if="opExibirBlocoMaior" :diaN="diaNp" :dia="diap" :mesEano="mesEanop" :isToday="isTodayp" :tarefasConcluidas="tarefasconcluidasp" :porcentagem="porcentagemp" :tarefasPendentes="tarefaspendentesp" @update:opAdicionarTarefa="opAdicionarTarefa = true" @update:opExibirBlocoMaior="opExibirBlocoMaior=false"></BlocoMaior>
  <BlocoMaiorRecolhido v-else :diaN="diaNp" :diaExtenso="diap" :mesEano="mesEanop" :isToday="isTodaypv" @update:opDetalhes="opExibirBlocoMaior=true"></BlocoMaiorRecolhido>
  <BlocoMenorExpandido v-if="opAdicionarTarefa" @salva:pagina="(pacote) => {taskPackage = pacote; opAdicionarTarefa = false}" @cancel:task="opAdicionarTarefa=false"> </BlocoMenorExpandido>
  <BlocoMenor :concluido="concluidop" :titulo="titulop" :corpo="corpop" :classe="classep" :hora="horap"></BlocoMenor>
</template>

<style scoped>

.conjuntoDosBlocos{
  display: flex;
  flex-direction: column;
  gap: 16px;
  width: fit-content;
}

.blocoMaior {
  width: 440px;
  box-sizing: border-box;
  background: linear-gradient(#eaf7e4 124px, #fff 124px);
  border: 1px solid #cfe5c8;
  border-radius: 16px;
  overflow: hidden;
  font-family: inherit;

  display: grid;
  grid-template-columns: 20px auto auto auto 1fr auto 20px;
  grid-template-rows: 20px 26px 18px 34px 6px 20px auto minmax(120px, auto) auto auto 16px;
}

/* ---------- BLOCO MAIOR RECOLHIDO (Pai Fechado) ---------- */
.blocoMaiorRecolhido {
  width: 440px;
  box-sizing: border-box;
  background: #eaf7e4;
  border: 1px solid #cfe5c8;
  border-radius: 16px;
  font-family: inherit;

  display: grid;
  grid-template-columns: 20px auto auto auto 1fr auto 20px;
  grid-template-rows: 20px 26px 18px 20px;
}

/* ---------- BLOCO MENOR (Filho Padrão) ---------- */
.blocoMenor {
  position: relative;
  width: 100%; /* 100% para se adaptar à coluna do BlocoMaior */
  height: 50px;
  box-sizing: border-box;
  padding: 4px 12px;
  background: #fff;
  border: 1px solid #cfe5c8;
  border-radius: 12px;

  display: grid;
  grid-template-columns: 24px 1fr auto auto;
  grid-template-rows: 1fr 1fr;
  column-gap: 8px;
  align-items: center;
}

/* ---------- BLOCO MENOR EXPANDIDO (Filho Aberto) ---------- */
.blocoMenorExpandido {
  position: relative;
  width: 100%; /* 100% para esticar certinho dentro do pai */
  height: 240px;
  box-sizing: border-box;
  padding: 20px;
  background: #eaf7e4;
  border: 1px solid #cfe5c8;
  border-radius: 12px;

  display: flex;
  flex-direction: column;
  gap: 12px;
}

</style>
