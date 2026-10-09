<script>
import BlocoMaior from './components/BlocoMaior.vue';
import BlocoMenor from './components/BlocoMenor.vue';
import BlocoMenorExpandido from './components/BlocoMenorExpandido.vue';

export default{
  name: "App",
  data(){
    return{

    }

  },
  components:{
        BlocoMenorExpandido,
        BlocoMenor,
        BlocoMaior,
  },
}
</script>

<template>

<main>
 
  <div class="">
    TESTE OVERLAY
    <!-- <BlocoMenorExpandido></BlocoMenorExpandido> -->
  </div>
 
  <div>
    <!-- <blocoMenor></blocoMenor> -->
  </div>

</main>
</template>

<style scoped>

</style>
