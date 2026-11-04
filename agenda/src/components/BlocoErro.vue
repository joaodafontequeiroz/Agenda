<script>
props:{
  opHoraFormatoErrado: false;
  opClasseNaoSelecionada: false;
}

</script>

<template>
  <div v-if="opHoraFormatoErrado === true" class="blocoErroFormatoHoraInvalido"></div>
  <div v-else-if="opClasseNaoSelecionada === true" class="blocoClasseNaoSelecionada"></div>
</template>

<style scoped>
.blocoErroFormatoHoraInvalido,
.blocoClasseNaoSelecionada {
  position: fixed;
  top: 24px;
  left: 50%;
  transform: translateX(-50%);
  z-index: 9999;

  box-sizing: border-box;
  width: max-content;
  max-width: calc(100vw - 32px);
  padding: 14px 20px;

  background-color: #f5faf2;
  color: #4b7e69;
  border: 1px solid #cce5bf;
  border-left: 4px solid #b87a58;
  border-radius: 14px;
  box-shadow: 0 6px 20px rgb(75 126 105 / 14%);

  font-family: inherit;
  font-size: 14px;
  line-height: 1.5;
  text-align: left;

  pointer-events: none;
  animation: aparecerErro 180ms ease-out;
}

.blocoErroFormatoHoraInvalido::before {
  content: "Horário inválido. Use o formato HH:mm.";
}

.blocoClasseNaoSelecionada::before {
  content: "Selecione uma categoria para a tarefa.";
}

@keyframes aparecerErro {
  from {
    opacity: 0;
    transform: translate(-50%, -8px);
  }

  to {
    opacity: 1;
    transform: translate(-50%, 0);
  }
}

@media (prefers-reduced-motion: reduce) {
  .blocoErroFormatoHoraInvalido,
  .blocoClasseNaoSelecionada {
    animation: none;
  }
}
</style>
