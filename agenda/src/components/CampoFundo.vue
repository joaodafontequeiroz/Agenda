<script>
export default{
  data(){
    return{

    }
  },

  props: {
    tema: Boolean,
  },

  emits: ['update:tema'],
}
</script>
<template>
  <div v-if="tema === true" class="pagina">
    <button class="butao" @click="$emit('update:tema', !tema)"></button>
    <slot></slot>
  </div>
  <div v-else class="pagina1">
    <button class="butao1" @click="$emit('update:tema', !tema)"></button>
    <slot></slot>
  </div>
</template>

<style scoped>
/* ===== MODO ESCURO ===== */
.pagina {
  --fundo: #121a12;
  --folha: #1b251b;
  --texto: #e6efe3;
  --texto-suave: #9fb29b;
  --placeholder: #5f735b;
  --borda: #3a4f3a;
  --destaque: #6fae60;
  color-scheme: dark;

  min-height: 100vh;
  padding: 32px 16px;
  box-sizing: border-box;
  background: var(--fundo);
  color: var(--texto);
  transition: background-color 0.25s, color 0.25s;
}

.butao {
  position: fixed;
  top: 16px;
  right: 16px;
  width: 40px;
  height: 40px;
  border-radius: 50%;
  border: 2px solid #3a4f3a;
  background: #2b3a2b;
  font-size: 1.1rem;
  line-height: 1;
  cursor: pointer;
  transition: background-color 0.25s, transform 0.15s;
}

.butao:hover {
  background: #364936;
}

.butao:active {
  transform: scale(0.92);
}

/* ===== MODO CLARO ===== */
.pagina1 {
  --fundo: #f4f8f1;
  --folha: #ffffff;
  --texto: #1f2d1f;
  --texto-suave: #5b6b5b;
  --placeholder: #a9b8a5;
  --borda: #cfe5c8;
  --destaque: #8fc47f;
  color-scheme: light;

  min-height: 100vh;
  padding: 32px 16px;
  box-sizing: border-box;
  background: var(--fundo);
  color: var(--texto);
  transition: background-color 0.25s, color 0.25s;
}

.butao1 {
  position: fixed;
  top: 16px;
  right: 16px;
  width: 40px;
  height: 40px;
  border-radius: 50%;
  border: 2px solid #cfe5c8;
  background: #e3f0dd;
  font-size: 1.1rem;
  line-height: 1;
  cursor: pointer;
  transition: background-color 0.25s, transform 0.15s;
}

.butao1:hover {
  background: #d3e8cb;
}

.butao1:active {
  transform: scale(0.92);
}
</style>
