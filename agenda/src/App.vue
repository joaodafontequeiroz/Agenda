<script>
import BlocoMenorExpandido from './components/BlocoMenorExpandido.vue';

export default{
  name: "App",
  data(){
    return{
      titulo: "Titulo",
      corpo: "Corpo",
    }

  },
  components:{
        BlocoMenorExpandido,
  },
}
</script>

<template>

<main>
  <div>
    TESTE OVERLAY
    <BlocoMenorExpandido></BlocoMenorExpandido>
  </div>
</main>
</template>

<style scoped>

</style>
